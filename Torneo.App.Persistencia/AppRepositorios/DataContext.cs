using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class DataContext : DbContext
    {
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Equipo> Equipos {get;set;}
        public DbSet<Jugadores> Jugadores {get;set;}
        public DbSet<DirectorTecnico> Tecnicos {get;set;}
        public DbSet<Partido> Partidos {get;set;}
        public DbSet<Posicion> Posicion {get;set;}
        protected override void OnConfiguring (DbContextOptionsBuilder  optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TorneoDB");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in
            modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}