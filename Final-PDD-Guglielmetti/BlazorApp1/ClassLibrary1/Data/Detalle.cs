using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrary1.Data
{
    [Table("Detalles")]
    public class Detalle
    {
        [Key]
        public int Id { get; set; } 

        public DateTime Fecha { get; set; }
        
        public String Tiempo { get; set; }

        public int RecursoId { get; set; }
		
        public Recurso Recurso { get; set; }
		
        public int TareaId { get; set; }

        public Detalle()
        {
        }

        public Detalle(int detalleId, DateTime fecha, string tiempo, int idRecursos, Recurso recurso, int tareaId)
        {
            Id = detalleId;
            Fecha = fecha;
            Tiempo = tiempo;
            RecursoId = idRecursos;
            Recurso = recurso;
            TareaId = tareaId;
        }

    }
}
