﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.statistics
{
    public class ListaVerificaionEvaResultDto
    {
        public IEnumerable<EvaluacionResultStatsDto> EvaluacionResultStatsList { get; set; }
        public string Nombre { get; set; }
        public IEnumerable<NivelesRiesgosDto> NivelesRiesgosList { get; set; }
    }
}
