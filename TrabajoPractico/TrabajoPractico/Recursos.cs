using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrabajoPractico
{
    class Recursos
    {
        [Key]
        public String nombre { get; set; }
        public Usuarios usuario { get; set; }

    }
}
