using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.statistics.Evaluacion
{
    public class ListaPruebaEvaluacionDto
    {
        public Prueba Prueba { get; set; }
        public bool Visbilidad { get; set; }
    }
}
