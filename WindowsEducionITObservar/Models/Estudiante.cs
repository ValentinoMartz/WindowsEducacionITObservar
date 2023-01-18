using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Estudiante 
    {

        [Key]
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string Telefono{ get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int IdLocalidad { get; set; }
        public Localidad Localidad { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

        //IdEstudiante
        //IdLocalidad
    }
}
