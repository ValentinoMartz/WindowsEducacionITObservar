using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WindowsEducionITObservar.Models
{
    public class Localidad
    {


        [Key]
        public int IdLocalidad { get; set; }
        public string Nombre { get; set;}

        public List<Estudiante> Estudiantes { get;set; }
        public List<Profesor> Profesores { get;set; }

       
    }
}
