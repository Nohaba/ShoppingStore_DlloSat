using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using ShoppingStore_DlloSat.DAL.Entities;

namespace ShoppingStore_DlloSat.DAL
{
    public class DataBaseContext : DbContext
    {
        //Se crea referencia DbContextOptions en este constructor, sirve para configurar las opciones
        //de la base de datos. Se usa la cadena de conexion a la DB
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base (options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();//Se controla la duplicidad de los paises
        }
        //DBSET para convertir mi clase country en una tabla de BD, el nombre sera contries
        public DbSet<Country> Countries { get; set; }
    }
}
