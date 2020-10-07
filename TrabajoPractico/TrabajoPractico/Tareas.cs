using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrabajoPractico
{
    class Tareas
    {
        [Key]
        public String titulo { get; set; }
        public DateTime vencimiento { get; set; }
        public int estimacion { get; set; }
        public String responsable { get; set; }
        public bool String { get; set; }

        
    }
}
