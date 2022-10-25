using Microsoft.EntityFrameworkCore;
using WebCrudMySQL.Models;

namespace WebCrudMySQL.Context
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {

        }
        
        public DbSet<Usuario> Usuario { get; set; }
        
    }
}
