using Microsoft.EntityFrameworkCore;
using testeMvc.Models;

namespace testeMvc.TesteContext
{
    public class Context: DbContext
    {
        public DbSet<Cliente>Clientes { get; set; }      

        private IConfiguration _configuration;      

        public Context(DbContextOptions<Context> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DbConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Cliente>(entity =>
            //{
            //    entity.ToTable("Clientes"); // Nome da tabela existente no banco
            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.NomeCliente).IsRequired().HasMaxLength(100);
            //    entity.Property(e => e.TelefoneCliente).HasMaxLength(20);
            //    // Outras configurações de propriedades
            //});

            // Configurações de outras entidades
        }

    }
}
