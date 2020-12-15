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



        //POSTS
        [Post("/DetalleController")]
        Task<List<DetalleService>> CrearDetalle();

        [Post("/RecursoController")]
        Task<List<RecursoService>> CrearRecurso();

        [Post("/TareaController")]
        Task<List<TareaService>> CrearTarea();

        [Post("/UsuarioController")]
        Task<List<UsuarioService>> CrearUsuario(Usuario usuario);

    }
}
