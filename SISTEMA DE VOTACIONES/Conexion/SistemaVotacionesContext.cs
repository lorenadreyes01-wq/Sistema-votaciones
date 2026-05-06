using Microsoft.EntityFrameworkCore;
using SISTEMA_DE_VOTACIONES.Entidades;

namespace SISTEMA_DE_VOTACIONES.Conexion

{
    public class SistemaVotacionesContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Plancha> Planchas { get; set; }
        public DbSet<Votacion> Votaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Votacion → Usuario
            modelBuilder.Entity<Votacion>()
                .HasOne(v => v.Usuario)
                .WithMany()
                .HasForeignKey(v => v.UsuarioId);

            // Votacion → Plancha
            modelBuilder.Entity<Votacion>()
                .HasOne(v => v.Plancha)
                .WithMany()
                .HasForeignKey(v => v.PlanchaId);

            // Plancha → Partido
            modelBuilder.Entity<Plancha>()
                .HasOne(p => p.Partido)
                .WithMany()
                .HasForeignKey(p => p.PartidoId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
        
                optionsBuilder.UseSqlServer(
                      "Data Source=LORENA-DURAN;Database=SistemaVotaciones;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;"); 
            }
        }
    }
}