using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Data;
using Refit;

namespace BlazorApp1.Data
{
    public class DetalleService
    {
        private DataContext context;
        
        public DetalleService(DataContext _context)
        {
            context = _context;
        }

        //Get desde la api:
        public async Task<Detalle> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.GetDetalle(id);
        }

        //Get desde la api:
        public async Task<List<Detalle>> GetDetalle(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.GetDetalleId(id);
        }

        //GetDetallePorTarea desde la api:
        public async Task<List<Detalle>> GetDetallePorTarea(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.GetDetallePorTarea(id);
        }


        // GetAllDetalles desde la api
        public async Task<List<Detalle>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            return await remoteService.GetAllDetalles();

        }

        //Para guardar desde la api:
        public async Task<Detalle> Save(Detalle valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.CrearDetalle(valor);
        }

        //Para BORRAR desde la api:
        public async Task<bool> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");
            return await remoteService.RemoveDetalle(id);
        }

        // GetAllRecursos desde la api
        public async Task<List<Recurso>> GetRecursos()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            return await remoteService.GetAllRecursos();

        }

        // GetAllTareas desde la api
        public async Task<List<Tarea>> GetTareas()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            return await remoteService.GetAllTareas();

        }
        // GetAllDetalles desde la api
        public async Task<List<Detalle>> GetDetalles()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            return await remoteService.GetAllDetalles();

        }


        /*Para hacer un get desde blazor:
		public async Task<Detalle> Get(int id)
		{
			return await context.Detalles.Where(i=>i.Id==id).SingleAsync();
		}*/

        /*
        //Para traerlo de la base:
        public async Task<List<Detalle>> GetAll()
        {
            return await context.Detalles.ToListAsync();
        }
        */

        /* Save desde blazor:
        public async Task<Detalle> Save(Detalle value)
        {
            if (value.Id == 0)
            {
                await context.Detalles.AddAsync(value);
            }
            else
            {
                context.Detalles.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }
        */

        //Para borrar desde blazor:
        /*
        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Detalles.Where(i => i.Id == id).SingleAsync();
            context.Detalles.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
        */


        /*
        //GetRecursos desde Blazor
        public async Task<List<Recurso>> GetRecursos()
        {
            return await context.Recursos.ToListAsync();
        }
        */

        //GetAllTareas y GetAllDetalles desde Blazor
        /*
        public async Task<List<Tarea>> GetTareas()
        {
            return await context.Tareas.ToListAsync();
        }

        public async Task<List<Detalle>> GetDetalles(int id)
        {
            return await context.Detalles.Where(i => i.TareaId == id).ToListAsync();
        }
        */
    }
}
