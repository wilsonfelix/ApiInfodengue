using Microsoft.EntityFrameworkCore;
using ApiInfoDengue.Domain;

namespace ApiInfoDengue.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Solicitante> Solicitantes { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<DadosEpidemiologicos> DadosEpidemiologicos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Solicitante>()
                .HasIndex(s => s.CPF)
                .IsUnique();

            modelBuilder.Entity<Solicitante>()
                .HasMany(s => s.Relatorios)
                .WithOne(r => r.Solicitante)
                .HasForeignKey(r => r.SolicitanteId);

            modelBuilder.Entity<DadosEpidemiologicos>().ToTable("DadosEpidemiologicos");
            modelBuilder.Entity<DadosEpidemiologicos>()
                .Property(d => d.CodigoIBGE)
                .IsRequired();
        }
    }
}
