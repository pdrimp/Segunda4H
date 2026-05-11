using Segunda4H.Data;

namespace Segunda4H.Repositorios
{
    public interface IRepositorioPersonas
    {
        Task<List<Persona>> ObtenerPersonasAsync();
    }
}
