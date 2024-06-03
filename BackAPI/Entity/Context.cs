using Microsoft.EntityFrameworkCore;

namespace BackAPI.Entity
{
    public class Context : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public Context()
        {
            //    Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Artem;Username=postgres;Password=Aa18062003@");
        }
    }
}
