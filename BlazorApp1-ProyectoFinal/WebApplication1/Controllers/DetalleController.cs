using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using ClassLibrary1.Data;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("{id}")]
        public async Task<Detalle> GetDetalle(int id)
        {
            return await _context.Detalles.Where(i => i.Id == id).SingleAsync();
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
