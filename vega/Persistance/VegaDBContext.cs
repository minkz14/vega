using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vega.Models;

namespace vega.Persistance
{
    public class VegaDBContext : DbContext
    {
        public VegaDBContext(DbContextOptions<VegaDBContext> options)
            : base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
    }
}
