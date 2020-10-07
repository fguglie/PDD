using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TrabajoPractico
{
    class Usuarios
    {
        [Key]
        public String Usuario { get; set; }
        public String Clave { get; set; }

    }
}
