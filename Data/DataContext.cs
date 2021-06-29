using DemoMVC4EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC4EF.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Restaurant> TblRestaurant { get; set; }
    }
}
