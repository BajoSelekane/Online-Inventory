using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace DB.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication2.Models.Product> Product { get; set; }

        public DbSet<WebApplication2.Models.Order> Order { get; set; }
    }
}
