using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrabajoPractico
{
    class Detalles
    {
        [Key]
        public DateTime fecha { get; set; }
        public String tiempo { get; set; }
        public Recursos recurso { get; set; }





    }
}
