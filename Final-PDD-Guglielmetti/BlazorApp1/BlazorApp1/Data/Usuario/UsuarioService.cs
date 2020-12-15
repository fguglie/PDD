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

        //Get desde la api:
        public async Task<Usuario> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.GetUsuario(id);
        }

        //Para guardar desde la api:
        public async Task<Usuario> Save(Usuario valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.CrearUsuario(valor);
        }

        //Remove desde la Api:
        public async Task<bool> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.RemoveUsuario(id);
        }

        //GetAll desde la api
        public async Task<List<Usuario>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            return await remoteService.GetAllUsuarios();

        }


        //Métodos para traerse la info desde Blazor

        /* GetAll desde Blazor
        public async Task<List<Usuario>> GetAll()
        {
            return await context.Usuarios.ToListAsync();
        }
        */

        //Save desde Blazor
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

        /*Get desde Blazor:
        public async Task<Usuario> Get(int id)
        {
            return await context.Usuarios.Where(i=>i.Id==id).SingleAsync();
        }*/


        //Remove desde Blazor
        /*
        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Usuarios.Where(i => i.Id == id).SingleAsync();
            context.Usuarios.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
        */
    }
}
