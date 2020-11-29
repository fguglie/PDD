using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrary1.Data
{
    [Table("Recursos")]
    public class Recurso
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public String Nombre { get; set; }

        public Usuario Usuario { get; set; }

        public int UsuarioId { get; set; }

        public Recurso() { }

        public Recurso(int recursoId, string nombre, Usuario usuario, int usuarioId)
        {
            Id = recursoId;
            Nombre = nombre;
            Usuario = usuario;
            UsuarioId = usuarioId;
        }

    }
}
