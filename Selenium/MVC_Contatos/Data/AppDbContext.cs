using Microsoft.EntityFrameworkCore;

namespace MVC_Contatos.Data.Models
{
    public class AppDbContext : DbContext
    {
        //Fazer testes de Multi Tenancy para este PRojeto
        //https://ericsmasal.com/2018/05/30/add-multi-tenancy-to-asp-net-core-identity/

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Contato>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }

    }
}
