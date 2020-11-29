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
    [Route("api/TareaController")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly DataContext _context;

        public TareaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Tarea> Get()
        {
            //return _context.Tareas.ToList();
            return _context.Tareas.Include(i => i.Responsable).ToList();
        }

        [HttpGet("{id}")]
        public async Task<Tarea> GetTarea(int id)
        {
            return await _context.Tareas.Where(i=>i.Id==id).SingleAsync();
        }

        [HttpPost]
        public Tarea Post(Tarea valor)
        {
            if (valor.Id == 0)
            {
                _context.Tareas.Add(valor);
            }
            else
            {
                _context.Tareas.Attach(valor);
                _context.Tareas.Update(valor);
            }
            _context.SaveChanges();
            return valor;
        }
    }
}
