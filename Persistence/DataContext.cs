using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    // Derive from entity framework class DbContext
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) // Pass options to base class (DbContext)
        {
        }

        // Properties inside the activites table will be based on the activity class
        public DbSet<Activity> Activities { get; set; }
    }
}