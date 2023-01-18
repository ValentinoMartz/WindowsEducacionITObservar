using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WindowsEducionITObservar.Models
{
    public class Plan
    {

        [Key]
        public int IdPlan { get; set; }
        public string Nombre { get; set; }
        public int IdCarrera { get; set; }
        public Carrera Carrera { get; set; }
    }
}
