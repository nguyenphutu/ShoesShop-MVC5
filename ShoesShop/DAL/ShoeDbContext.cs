using ShoesShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoesShop.DAL
{
    public class ShoeDbContext : DbContext
    {
        public ShoeDbContext()
        {

        }
        public DbSet<Shoes> Shoes { get; set; }
        public DbSet<ImagesShoe> ImagesShoe { get; set; }
    }
}