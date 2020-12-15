using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1.Data
{
    [Table("Tarea")]
    public class Tarea
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int RecursoId { get; set; }
        public Recurso Responsable { get; set; }
        public bool Estado { get; set; }

        public Tarea() 
        {

        }

        public Tarea(int id, string titulo, DateTime vencimiento, int estimacion, int recursoId, Recurso responsable, bool estado)
        {
            this.Id = Id;
            this.Titulo = titulo;
            this.Vencimiento = vencimiento;
            this.Estimacion = estimacion;
            this.RecursoId = recursoId;
            this.Responsable = responsable;
            this.Estado = estado;
        }
    }
}
