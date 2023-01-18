using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Carrera
    {
        [Key]
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }

        public List<Planilla> Planillas { get; set; }
        public List<Plan> Planes { get; set; }


    }
}
