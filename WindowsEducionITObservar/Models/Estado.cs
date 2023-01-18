using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }
        public string Nombre { get; set; }
        public List<Detalle> Detalles { get; set;}
        
    }
}
