using MedFas1.Data.Models;
using MedFast1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Data;

namespace MedFast.Data
{
    public class ShopContext : IdentityDbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) :
            base(options)
            {

      }
        public DbSet<Shops> Shop { get; set; }
        public DbSet<Medicine> Medicines { get; set; }

   

    }
}
