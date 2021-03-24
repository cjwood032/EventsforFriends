using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Events.Models
{
    public class User
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public List<Interest> UserInterests { get; set; }
        public List<Interest> AllInterests { get; set; }
        public Boolean Admin { get; set; }
        public Boolean Owner { get; set; }

    }
}
