using MedFas1.Data.Models;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using MedFas1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
