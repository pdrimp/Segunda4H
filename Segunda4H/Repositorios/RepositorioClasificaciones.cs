using Microsoft.EntityFrameworkCore;
using Segunda4H.Data;

namespace Segunda4H.Repositorios
{
    public class RepositorioClasificaciones(DirectorioDBContext context) : IRepositorioClasificaciones
    {
        readonly DirectorioDBContext _context = context;

        public async Task ActualizarClasificacion(int id, Clasificacion clasificacion)
        {
            var clasificacionExistente = _context.Clasificaciones.Find(id);
            if (clasificacionExistente == null)
            {
                throw new Exception("Clasificación no encontrada");
            }
            clasificacionExistente.Nombre = clasificacion.Nombre;
            await _context.SaveChangesAsync();
        }

        public async Task AgregarClasificacion(Clasificacion clasificacion)
        {
            await _context.Clasificaciones.AddAsync(clasificacion);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarClasificacion(int id)
        {
            await _context.Clasificaciones.Where(c => c.Id == id).ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }

        public async Task<Clasificacion?> ObtenerClasificacionPorId(int id)
        {
            return await _context.Clasificaciones.FindAsync(id);
        }

        public async Task<List<Clasificacion>> ObtenerClasificaciones()
        {
            return await _context.Clasificaciones.Include(c => c.Personas).ToListAsync();
        }
    }
}
