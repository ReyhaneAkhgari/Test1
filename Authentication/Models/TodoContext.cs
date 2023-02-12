using Authentication.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;


namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public TodoContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase")!);
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;

        public DbSet<AuthenticateModel> AuthenticateModel { get; set; } = null!;

    }

    
}
namespace Authentication.Models
{

}

