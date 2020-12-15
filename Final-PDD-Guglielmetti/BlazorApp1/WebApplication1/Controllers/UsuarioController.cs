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
    [Route("api/UsuarioController")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;

        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            return _context.Usuarios.ToList();
        }

        [HttpGet("{id}")]
        public async Task<Usuario> GetUsuario(int id)
        {
            return await _context.Usuarios.Where(i => i.Id == id).SingleAsync();
        }

        [HttpDelete("{id}")]
        public async Task<bool> Remove(int id)
        {
            var entidad = await _context.Usuarios.Where(i => i.Id == id).SingleAsync();
            _context.Usuarios.Remove(entidad);
            await _context.SaveChangesAsync();
            return true;
        }


        [HttpPost]
        public Usuario Post(Usuario valor)
        {
            if (valor.Id == 0)
            {
                _context.Usuarios.Add(valor);
            }
            else
            {
                _context.Usuarios.Attach(valor);
                _context.Usuarios.Update(valor);
            }
            _context.SaveChanges();
            return valor;
        }
    }
}
