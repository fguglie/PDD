using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using ClassLibrary1.Data;
using Refit;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        private DataContext context;
        
        public TareaService(DataContext _context)
        {
            context = _context;
        }

        //Get desde la api:
        public async Task<Tarea> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.GetTarea(id);
        }

        // GetAll desde la api
        public async Task<List<Tarea>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            return await remoteService.GetAllTareas();

        }

        //Para guardar desde la api:
        public async Task<Tarea> Save(Tarea valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.CrearTarea(valor);
        }

        // GetAllRecursos desde la api
        public async Task<List<Recurso>> GetRecurso()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            return await remoteService.GetAllRecursos();

        }

        //Remove desde la Api:
        public async Task<bool> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.RemoveTarea(id);
        }



        //Métodos desde Blazor:

        /*Get desde blazor:
        public async Task<Tarea> Get(int id)
        {
            return await context.Tareas.Where(i=>i.Id==id).SingleAsync();
        }
        */

        /*
        //Para traerlo desde la base:
        public async Task<List<Tarea>> GetAll()
        {
            return await context.Tareas.ToListAsync();
        }
        */

        /*
        public async Task<Tarea> Save(Tarea value)
        {
            if (value.Id == 0)
            {
                await context.Tareas.AddAsync(value);
            }
            else
            {
                context.Tareas.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }
        */

        //Remove desde Blazor
        /*
        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Tareas.Where(i => i.Id == id).SingleAsync();
            context.Tareas.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
        */

        //GetAllRecursos desde Blazor
        /*
        public async Task<List<Recurso>> GetRecurso()
        {
            return await context.Recursos.ToListAsync();
        }
        */

    }
}
