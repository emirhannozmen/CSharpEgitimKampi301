using CSharpEgitimKampi301.EntityLayer.Concrete;
using System.Data.Entity;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
