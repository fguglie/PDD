using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using ClassLibrary1.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    [Route("api/DetalleController")]
    [ApiController]
    public class DetalleController : ControllerBase
    {
        private readonly DataContext _context;

        public DetalleController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Detalle> Get()
        {
            //return _context.Detalles.ToList();
            return _context.Detalles.Include(i => i.Recurso).ToList();
        }

        /*BACKUP
        [HttpGet("{id}")]
        public async Task<Detalle> GetDetalle(int id)
        {
            return await _context.Detalles.Where(i => i.Id == id).SingleAsync();
        } 
        */
        
        [HttpGet("{id}")]
        public async Task<List<Detalle>> GetDetalle(int id)
        {
            var res = _context.Detalles.Where(i => i.Id == id).AsNoTracking().ToList();
            //<List<Detalle>> model = JsonConvert.DeserializeObject<List<Detalle>>(res);
            //Console.WriteLine("RESPUESTA!!" + res);
            //var enrollment = "";
            //<List<Detalle>> enrollment = JsonConvert.DeserializeObject<List<Detalle>>(res);
            return res;
        }

        /*
        [HttpGet("{id}")]
        public async Task<List<Detalle>> GetDetallePorTarea(int id)
        {
            var res = _context.Detalles.Where(i => i.TareaId == id).AsNoTracking().ToList();
            //<List<Detalle>> model = JsonConvert.DeserializeObject<List<Detalle>>(res);
            //Console.WriteLine("RESPUESTA!!" + res);
            //var enrollment = "";
            //<List<Detalle>> enrollment = JsonConvert.DeserializeObject<List<Detalle>>(res);
            return res;
        }*/

        [HttpDelete("{id}")]
        public async Task<bool> Remove(int id)
        {
            var entidad = await _context.Detalles.Where(i => i.Id == id).SingleAsync();
            _context.Detalles.Remove(entidad);
            await _context.SaveChangesAsync();
            return true;
        }


        [HttpPost]
        public Detalle Post(Detalle valor)
        {
            if(valor.Id == 0)
            {
                _context.Detalles.Add(valor);
            }
            else
            {
                _context.Detalles.Attach(valor);
                _context.Detalles.Update(valor);
            }
            _context.SaveChanges();
            return valor;
        }

    }
}
