using MedFas1.Data.Models;
using Microsoft.EntityFrameworkCore;
using Shop.Data;

namespace MedFast.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) :
            base(options)
            {
}
        public DbSet<Shops> Shop { get; set; }
        public DbSet<Medicine> Medicines { get; set; }



    }
}
