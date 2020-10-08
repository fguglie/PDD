using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrabajoPractico
{
    [Table("Recursos")]
    class Recursos
    {
        [Key]
        [MaxLength(20)]
        public String Nombre { get; set; }

        [Required]
        public Usuarios Usuario { get; set; }

    }
}
