using HandsArts.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HandsArts.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<TiendaCategory> TiendasCategories { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Rubro> Rubros { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Empresa>()
                .HasOne(e => e.Rubro)             // Una Empresa tiene un Rubro
                .WithMany(r => r.Empresas)        // Un Rubro tiene muchas Empresas
                .HasForeignKey(e => e.RubroId)    // Clave foránea en Empresa
                .OnDelete(DeleteBehavior.Restrict); // Configuración de comportamiento en eliminación

            builder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.RutEmpresa);
                entity.Property(e => e.NombreEmpresa).IsRequired().HasMaxLength(50);
                entity.Property(e => e.RazonSocial).IsRequired().HasMaxLength(50);
                entity.Property(e => e.GiroComercial).IsRequired().HasMaxLength(50);
                entity.Property(e => e.PoliticaDevoluciones).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DirecciónComercial).IsRequired().HasMaxLength(100);
                entity.Property(e => e.NumeroRegistroTributario).IsRequired().HasMaxLength(50);
                entity.Property(e => e.ModoEnvioPreferido).IsRequired();
            });
            // Configuración de la relación uno a uno entre Empresa y Tienda
            builder.Entity<Empresa>()
                .HasOne(e => e.Tienda)          // Una Empresa tiene una Tienda
                .WithOne()                      // Una Tienda no necesariamente tiene que tener una Empresa (si es opcional)
                .HasForeignKey<Empresa>(e => e.TiendaId); // Clave foránea en Empresa

            builder.Entity<Empresa>()
                .Property(e => e.EstadoVerificacion)
                .HasDefaultValue(false); // Valor predeterminado (opcional)

        }


    }
}