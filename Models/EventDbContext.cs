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
        public DbSet<User> users { get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<Interest> interests { get; set; }
        public DbSet<Participant> participants { get; set; }
        public DbSet<UserGroup> userGroups { get; set; }
    }
}
