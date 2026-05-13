using Segunda4H.Data;

namespace Segunda4H.Repositorios
{
    public interface IRepositorioPersonas
    {
        Task AgregarPersona(Persona persona);
        Task<List<Persona>> ObtenerPersonas();
        Task<Persona?> ObtenerPersonaPorId(int id);
        Task ActualizarPersona(int id, Persona persona);
        Task EliminarPersona(int id);
    }
}
