using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Detalle
    {
        [Key]

        public int IdDetalle { get; set; }
        public int IdPlanilla { get; set; }
        public Planilla Planilla { get; set; }
        public int IdEstado { get; set; }
        public Estado Estado { get; set; }
        public List<Evaluacion> Evalaciones { get; set;}
    }
}
