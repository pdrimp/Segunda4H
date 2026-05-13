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

        public async Task ActualizarPersona(int id, Persona persona)
        {
            var personaExistente = _context.Personas.Find(id);
            if (personaExistente == null)
            {
                throw new Exception("Persona no encontrada");
            }
            personaExistente.Nombre = persona.Nombre;
            personaExistente.Correo = persona.Correo;
            personaExistente.Telefono = persona.Telefono;
            personaExistente.Genero = persona.Genero;
            await _context.SaveChangesAsync();
        }

        public async Task AgregarPersona(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarPersona(int id)
        {
            await _context.Personas.Where(p => p.Id == id).ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }

        public async Task<Persona?> ObtenerPersonaPorId(int id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task<List<Persona>> ObtenerPersonas()
        {
            return await _context.Personas.ToListAsync();
        }

    }
}
