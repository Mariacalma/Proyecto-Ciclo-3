using Microsoft.EntityFrameworkCore;
using pypSln.App.dominio;
namespace pypSln.App.persistencia
{
    public class appContext : DbContext
    {
        public DbSet<persona> persona { get; set; }
        public DbSet<propietario> propietario { get; set; }
        public DbSet<veterinario> veterinario { get; set; }
        public DbSet<ovino> ovino { get; set; }
        public DbSet<visitapyp> visitapyp { get; set; }
        public DbSet<registroHistoria> registroHistoria { get; set; }
        public DbSet<historiaClinica> historiaClinica { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured)// configuracion de la base de datos
            {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=jornadapyp_v1");
            }
        }
    }
}