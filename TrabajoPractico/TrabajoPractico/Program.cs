using System;
using System.Collections;
using System.Linq;

namespace TrabajoPractico
{
    public class Program
    {
        static void Main()
        {
            //Inserción de usuarios:
            InsertarUsuario("Federico", "Fede1234");
            InsertarUsuario("Gabriel", "clave1234");
            InsertarUsuario("Martina", "hola!");

            //Consulta de todos los usuarios:
            ConsultarTodosLosUsuarios();

            //Consultar un usuario:
            ConsultarUsuario("Federico");

            //Actualización de un usuario:
            ActualizarUsuario("Federico","Federico1");

            //Actualización de un usuario y su clave:
            ActualizarUsuario("Federico1", "Federico2","nuevaclave");

            //Borrar usuario:
            BorrarUsuario("Martina");
        }

        //Método para borrar un usuario:
        static void BorrarUsuario(string UsuarioABorrar)
        {
            var ctx = new TPDBContext();
            var usuario = ctx.Usuarios.Where(i => i.Usuario == UsuarioABorrar).FirstOrDefault();
            if (usuario != null)
            {
                ctx.Usuarios.Remove(usuario);
            }
            else
            {
                Console.WriteLine("El usuario a borrar no existe.");
            }
            ctx.SaveChanges();
        }
        
        //Método para actualizar un usuario (Nombre solo ó Nombre y Clave):
        static void ActualizarUsuario(string UsuarioABuscar, string NuevoNombreDeUsuario, string NuevaClave = "na")
        {
            var ctx = new TPDBContext();

            var usuario = ctx.Usuarios.Where(i => i.Usuario == UsuarioABuscar).FirstOrDefault();
            if (usuario != null)
            {
                usuario.Usuario = NuevoNombreDeUsuario;
                
                if(NuevaClave != "na")
                {
                    usuario.Clave = NuevaClave;
                }
            }
            else
            {
                Console.WriteLine("El usuario a modificar no existe.");
            }
            ctx.SaveChanges();
        }

        //Método para Consultar todos los usuarios
        static void ConsultarTodosLosUsuarios()
        {
            var ctx = new TPDBContext();

            var lista = ctx.Usuarios.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre del usuario: {item.Usuario}\nClave: ({item.Clave})");
            }
        }

        //Método para Consultar un usuario
        static void ConsultarUsuario(string UsuarioABuscar)
        {
            var ctx = new TPDBContext();

            var usuario = ctx.Usuarios.Where(i => i.Usuario == UsuarioABuscar).FirstOrDefault();
            if (usuario != null)
            {
                Console.WriteLine($"Nombre del usuario: {usuario.Usuario}\nClave: ({usuario.Clave})");
            }
            else
            {
                Console.WriteLine("El usuario ingresado no existe.");
            }
            ctx.SaveChanges();
        }


        //Método para Insertar un usuario
        static void InsertarUsuario(string Usuario, string Clave)
        {
            var ctx = new TPDBContext();

            ctx.Usuarios.Add(new Usuarios
            {
                Usuario = Usuario,
                Clave   = Clave
            });

            ctx.SaveChanges();
        }














        
    }
}
