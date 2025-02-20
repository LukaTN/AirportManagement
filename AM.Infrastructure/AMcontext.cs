using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace AM.Infrastructure
{
    public class AMcontext : DbContext
    {
        //1dbset
        public DbSet<Flight> Flights   { get; set; }
            
        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Traveller> Travellers { get; set; }

        public DbSet<Plane> Planes { get; set; }
        
        public DbSet<Staff> Staffs { get; set; }


        // 2 chaine de connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=AmArctic4;Integrated Security=true"); base.OnConfiguring(optionsBuilder);
        }


    }
}
