using HotalManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotalManagementSystem.HMSContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
        public DbSet<Dish>Dishes { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<Cook> Cooks { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
