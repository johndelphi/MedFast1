using Microsoft.EntityFrameworkCore;
using Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedFastreact.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options): base(options)
            {
}
        public DbSet<Shops> Shop { get; set; } = null!;
//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
            //optionsBuilder.UseSqlServer("server =.; Database=MEDfastAPI; Intergrated Security=True");
            //base.OnConfiguring(optionsBuilder);
        //}

    }
}
