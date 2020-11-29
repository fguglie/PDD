using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Data;
using Refit;

namespace BlazorApp1.Data
{
    public class RecursoService
    {
        private DataContext context;
        
        public RecursoService(DataContext _context)
        {
            context = _context;
        }

        /*Get desde blazor:
        public async Task<Recurso> Get(int id)
        {
            return await context.Recursos.Where(i=>i.Id==id).SingleAsync();
        }
        */

        //Get desde la api:
        public async Task<Recurso> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.GetRecurso(id);
        }

        /*
        //Para traerlo de la base:
        public async Task<List<Recurso>> GetAll()
        {
            return await context.Recursos.ToListAsync();
        }
        */

        // GetAll desde la api
        public async Task<List<Recurso>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            return await remoteService.GetAllRecursos();

        }

        /* Para guardar desde el blazor:
        public async Task<Recurso> Save(Recurso value)
        {
            if (value.Id == 0)
            {
                await context.Recursos.AddAsync(value);
            }
            else
            {
                context.Recursos.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }
        */

        //Para guardar desde la api:
        public async Task<Recurso> Save(Recurso valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.CrearRecurso(valor);
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Recursos.Where(i => i.Id == id).SingleAsync();
            context.Recursos.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            return await context.Usuarios.ToListAsync();
        }

        /*public async Task<List<Rol>> GetRoles()
        {
            return await context.Roles.ToListAsync();
        }*/

    }
}
