using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabajoPractico
{
    [Table("Usuarios")]
    class Usuarios
    {
        [Key]
        [MaxLength(10)]
        [MinLength(1)]
        public String Usuario { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(4)]
        public String Clave { get; set; }

    }
}
