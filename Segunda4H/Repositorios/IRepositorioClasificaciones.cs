using Segunda4H.Data;

namespace Segunda4H.Repositorios
{
    public interface IRepositorioClasificaciones
    {
        Task AgregarClasificacion(Clasificacion clasificacion);
        Task<List<Clasificacion>> ObtenerClasificaciones();
        Task<Clasificacion?> ObtenerClasificacionPorId(int id);
        Task ActualizarClasificacion(int id, Clasificacion clasificacion);
        Task EliminarClasificacion(int id);
    }
}
