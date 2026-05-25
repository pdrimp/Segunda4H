using Segunda4H.Data;

namespace Segunda4H.Repositorios
{
    public interface IRepositorioHabitos
    {
        Task AgregarHabito(Habito habito);
        Task<List<Habito>> ObtenerHabitos();
        Task<Habito?> ObtenerHabitoPorId(int id);
        Task ActualizarHabito(int id, Habito habito);
        Task EliminarHabito(int id);
    }
}
