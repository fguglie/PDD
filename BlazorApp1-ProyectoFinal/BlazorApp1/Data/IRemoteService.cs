using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using ClassLibrary1.Data;

namespace BlazorApp1.Data
{
    interface IRemoteService
    {
        //GETS
        [Get("/DetalleController")]
        Task<List<Detalle>> GetAllDetalles();

        [Get("/RecursoController")]
        Task<List<Recurso>> GetAllRecursos();

        [Get("/TareaController")]
        Task<List<Tarea>> GetAllTareas();

        [Get("/UsuarioController")]
        Task<List<Usuario>> GetAllUsuarios();


        
        [Get("/DetalleController/{id}")]
        Task<Detalle> GetDetalle(int id);

        [Get("/RecursoController/{id}")]
        Task<Recurso> GetRecurso(int id);

        [Get("/TareaController/{id}")]
        Task<Tarea> GetTarea(int id);

        [Get("/UsuarioController/{id}")]
        Task<Usuario> GetUsuario(int id);




        //POSTS
        [Post("/DetalleController")]
        Task<Detalle> CrearDetalle(Detalle valor);

        [Post("/RecursoController")]
        Task<Recurso> CrearRecurso(Recurso valor);

        [Post("/TareaController")]
        Task<Tarea> CrearTarea(Tarea valor);

        [Post("/UsuarioController")]
        Task<Usuario> CrearUsuario(Usuario valor);

    }
}
