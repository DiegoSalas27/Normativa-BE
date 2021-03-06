using Aplicacion.Dtos;
using MediatR;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Aplicacion.ManejadorError;
using System.Net;

namespace Aplicacion.Pruebas
{
    public class OptimizationRequest
    {
        public class Listar : IRequest<ObtenerObjetoAccionesMitigacionDto>
        {
            public decimal PorcentajeDeseado { get; set; }
            public decimal Margen { get; set; }
            public ResultadoPruebaDto Response { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, ObtenerObjetoAccionesMitigacionDto>
        {
            private readonly NormativaContext _context;
            private IMediator _mediator;
            protected IMediator Mediator => _mediator;

            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<ObtenerObjetoAccionesMitigacionDto> Handle(Listar request, CancellationToken cancellationToken)
            {
                try
                {
                    var responseObtener = request.Response;

                    var arrayList = new List<Guid>();

                    var porcentaje = "";

                    using (var httpClient = new HttpClient())
                    {

                       
                        httpClient.Timeout = TimeSpan.FromMinutes(10);

                        var serializer = new JsonSerializer()
                        {
                            ContractResolver = new CamelCasePropertyNamesContractResolver()
                        };

                        var json = JObject.FromObject(responseObtener, serializer);

                        StringContent content = new StringContent(JsonConvert.SerializeObject(json), Encoding.UTF8, "application/json");

                        using (var response = await httpClient.PostAsync("https://algoritmo-mitigaciones-ejs.herokuapp.com/api/enhance/" + request.PorcentajeDeseado +'/'+ request.Margen, content))
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            var responseFinal = JsonConvert.DeserializeObject<HerokuResponseDto>(apiResponse);
                            porcentaje = responseFinal.limit;
                            foreach (var result in responseFinal.objResult)
                            {
                                arrayList.Add(result.requerimientoId);
                            }
                        }
                    }
                    var cosito = new ObtenerObjetoAccionesMitigacionDto { requeid = arrayList, limit = porcentaje };
                    return cosito;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new ManejadorExcepcion(HttpStatusCode.BadRequest, new { mensaje = "Por favor intente con otro valor" });
                }
            } 
        }
    }
}
