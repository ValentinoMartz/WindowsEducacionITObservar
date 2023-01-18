using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Planilla
    {
        [Key]
        public int IdPlanilla { get; set; }
        public DateTime Fecha { get; set; }
        public List<Detalle> Detalles { get; set; }

        public int IdProfesor { get; set; }
        public Profesor Profesor { get; set; }

        public int IdMateria { get; set; }
        public Materia Materia { get; set; }

        public int IdCarrra { get; set; }
        public Carrera Carrera { get; set; }

        public int IdCurso { get; set; }
        public Curso Curso{ get; set; }

    }
}
