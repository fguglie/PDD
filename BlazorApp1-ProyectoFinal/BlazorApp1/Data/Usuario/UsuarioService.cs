using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Data;
using Refit;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        private DataContext context;
        
        public UsuarioService(DataContext _context)
        {
            context = _context;
        }

        /*Get desde Blazor:
        public async Task<Usuario> Get(int id)
        {
            return await context.Usuarios.Where(i=>i.Id==id).SingleAsync();
        }*/


        //Get desde la api:
        public async Task<Usuario> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.GetUsuario(id);
        }


        /* Se comenta, ya que está en desuso, dado que se obtiene el listado de Usuarios desde la api
        public async Task<List<Usuario>> GetAll()
        {
            return await context.Usuarios.ToListAsync();
        }
        */


        // GetAll desde la api
        public async Task<List<Usuario>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            //CREAR USUARIO
            //await remoteService.CrearUsuario(new Usuario { Nombre="Fede", Clave= "1234", Id = 1 });

            return await remoteService.GetAllUsuarios();

        }

        /*
        public async Task<Usuario> Save(Usuario value)
        {
            if (value.Id == 0)
            {
                await context.Usuarios.AddAsync(value);
            }
            else
            {
                context.Usuarios.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }
        */


        //Para guardar desde la api:
        public async Task<Usuario> Save(Usuario valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.CrearUsuario(valor);
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Usuarios.Where(i => i.Id == id).SingleAsync();
            context.Usuarios.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
