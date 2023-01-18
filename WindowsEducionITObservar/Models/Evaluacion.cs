using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WindowsEducionITObservar.Models
{
    public class Evaluacion
    {
        [Key]
        public int IdEvaluacion { get; set; }
        public int Nota { get; set; }

        public int IdEstudiante { get; set; }

        public Estudiante Estudiante { get; set; }
        public int IdTipo { get; set; }
        public Tipo Tipo { get; set; }
        public int IdDetalle { get; set; }
        public Detalle Detalle { get; set; }


    }
}
