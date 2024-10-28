using Microsoft.EntityFrameworkCore;
using MVCpractica2.Models;

namespace MVCpractica2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Aqui todos los modelos que se creen 
        //public DbSet<Producto> Producto { get; set; }
        public DbSet<Producto> Producto { get; set; }
    }



}
