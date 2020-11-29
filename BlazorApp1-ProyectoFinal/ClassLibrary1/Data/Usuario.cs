using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1.Data
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public Usuario() { }

        public Usuario(int id, String nombre, String clave)
        {
            Id = id;
            Nombre = nombre;
            Clave = clave;
        }
    }
}
