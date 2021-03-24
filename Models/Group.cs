using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Events.Models
{
    public class Group
    {
        [Key]
        public long GroupID { get; set; }
        public string GroupName { get; set; }
        public long OwnerID { get; set; }
    }
}
