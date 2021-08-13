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

namespace Aplicacion.Pruebas
{
    public class OptimizationRequest
    {
        public class Listar : IRequest<List<Guid>>
        {
            public decimal PorcentajeDeseado { get; set; }
            public ResultadoPruebaDto Response { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, List<Guid>>
        {
            private readonly NormativaContext _context;
            private IMediator _mediator;
            protected IMediator Mediator => _mediator;

            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<List<Guid>> Handle(Listar request, CancellationToken cancellationToken)
            {
                var responseObtener = request.Response;

                var arrayList = new List<Guid>();

                using (var httpClient = new HttpClient())
                {
                    var serializer = new JsonSerializer()
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };

                    var json = JObject.FromObject(responseObtener, serializer);

                    StringContent content = new StringContent(JsonConvert.SerializeObject(json), Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync("https://dry-earth-03574.herokuapp.com/api/enhance/" + request.PorcentajeDeseado, content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var responseFinal = JsonConvert.DeserializeObject<HerokuResponseDto>(apiResponse);
                        foreach (var result in responseFinal.objResult)
                        {
                            arrayList.Add(result.requerimientoId);
                        }
                    }
                }

                return arrayList;
            }
        }
    }
}
