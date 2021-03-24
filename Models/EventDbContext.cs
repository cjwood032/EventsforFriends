using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Events.Models
{
    public class EventDbContext : DbContext
    {
        public EventDbContext() : base("TLS")
        {

        }
        public DbSet<Shindig> shindigs { get; set; }

    }
}
