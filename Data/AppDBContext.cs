using Microsoft.EntityFrameworkCore;

namespace Parcial1_Prog3.Data
{
    public class AppDBContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MA09TKJ\\SQLEXPRESS;Database=Parcial1_Prog3;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Models.Producto> Productos { get; set; }



    }
}
