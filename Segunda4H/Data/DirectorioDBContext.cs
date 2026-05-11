using Microsoft.EntityFrameworkCore;

namespace Segunda4H.Data
{
    public class DirectorioDBContext(DbContextOptions<DirectorioDBContext> options) : DbContext(options)
    {
        public DbSet<Persona> Personas { get; set; }
    }
}
