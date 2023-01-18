using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Curso
    {
        [Key]

        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public List<Planilla> Planillas { get; set; }
    }
}
