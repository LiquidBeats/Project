using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloRiesgosSG_SST.Entidades.Proveedores
{
    class EClEvaluacion
    {
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaCiclo { get; set; }
        public int Puntaje { get; set; }
        public string Descripcion { get; set; }
    }
}
