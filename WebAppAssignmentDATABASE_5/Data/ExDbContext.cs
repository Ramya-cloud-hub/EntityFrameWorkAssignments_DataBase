using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class ExDbContext : DbContext
    {


        public ExDbContext(DbContextOptions<ExDbContext> options) : base(options) { }
        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
        public DbSet<Person> Peoples { get; set; }
        public DbSet<Country> Countries{ get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
