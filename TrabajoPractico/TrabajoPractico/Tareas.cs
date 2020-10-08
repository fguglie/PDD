using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrabajoPractico
{
    [Table("Tareas")]
    class Tareas
    {
        [Key]
        [MaxLength(10)]
        public String Titulo { get; set; }

        public DateTime Vencimiento { get; set; }

        public int Estimacion { get; set; }

        [MaxLength(30)]
        public String Responsable { get; set; }

        [Required]
        public bool Estado { get; set; }

        
    }
}
