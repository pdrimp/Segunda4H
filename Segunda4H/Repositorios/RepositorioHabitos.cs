using Microsoft.EntityFrameworkCore;
using Segunda4H.Data;

namespace Segunda4H.Repositorios
{
    public class RepositorioHabitos(DirectorioDBContext context) : IRepositorioHabitos
    {
        readonly DirectorioDBContext _context = context;

        public async Task ActualizarHabito(int id, Habito habito)
        {
            var habitoExistente = _context.Habitos.Find(id);
            if (habitoExistente == null)
            {
                throw new Exception("Hábito no encontrado");
            }
            habitoExistente.Nombre = habito.Nombre;
            await _context.SaveChangesAsync();
        }

        public async Task AgregarHabito(Habito habito)
        {
            await _context.Habitos.AddAsync(habito);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarHabito(int id)
        {
            await _context.Habitos.Where(c => c.Id == id).ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }

        public async Task<Habito?> ObtenerHabitoPorId(int id)
        {
            return await _context.Habitos.AsNoTracking().FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Habito>> ObtenerHabitos()
        {
            return await _context.Habitos.AsNoTracking().Include(c => c.Personas).ToListAsync();
        }
    }
}
