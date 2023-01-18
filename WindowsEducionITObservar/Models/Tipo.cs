using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public  class Tipo
    {
        [Key]
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }
    }
}
