using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrabajoPractico
{
    [Table("Detalles")]
    class Detalles
    {
        [Key]
        public DateTime Fecha { get; set; }
        
        public String Tiempo { get; set; }
        
        [Required]
        public Recursos Recurso { get; set; }





    }
}
