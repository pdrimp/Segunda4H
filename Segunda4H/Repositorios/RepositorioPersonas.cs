using Microsoft.EntityFrameworkCore;
using Segunda4H.Data;

namespace Segunda4H.Repositorios
{
    public class RepositorioPersonas : IRepositorioPersonas
    {
        readonly DirectorioDBContext _context;

        public RepositorioPersonas(DirectorioDBContext context)
        {
            _context = context;
        }

        public async Task<List<Persona>> ObtenerPersonasAsync()
        {
            return await _context.Personas.ToListAsync();
        }
    }
}
