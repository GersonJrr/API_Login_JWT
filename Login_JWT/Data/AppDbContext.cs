using Login_JWT.Models;
using Microsoft.EntityFrameworkCore;

namespace Login_JWT.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UsuarioModel> Usuario { get; set; }

        public DbSet<Task> Tasks { get; set; }
    }
}
