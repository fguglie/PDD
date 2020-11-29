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
    [Route("api/RecursoController")]
    [ApiController]
    public class RecursoController : ControllerBase
    {
        private readonly DataContext _context;

        public RecursoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Recurso> Get()
        {
            //return _context.Recursos.ToList();
            return _context.Recursos.Include(i => i.Usuario).ToList();
        }


        [HttpGet("{id}")]
        public async Task<Recurso> GetRecurso(int id)
        {
            return await _context.Recursos.Where(i => i.Id == id).SingleAsync();
        }
        

        [HttpPost]
        public Recurso Post(Recurso valor)
        {
            if (valor.Id == 0)
            {
                _context.Recursos.Add(valor);
            }
            else
            {
                _context.Recursos.Attach(valor);
                _context.Recursos.Update(valor);
            }
            _context.SaveChanges();
            return valor;
        }
    }
}
