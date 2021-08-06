using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Aplicacion.Dtos;

namespace Aplicacion
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ListaVerificacion, ObtenerListaVerificacionDto>()
                .ForMember(x => x.Requerimientos, y => y.MapFrom(z => z.RequerimientoList))
                .ForMember(x => x.RequerimientosCount, y => y.MapFrom(z => z.RequerimientoList.Count));
        }
    }
}
