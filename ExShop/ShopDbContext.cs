using System.Data.Entity;

namespace ExShop
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base("ShopDbContext" )
        {
        }
        public DbSet<Item> Items { get; set; }
    }
}
