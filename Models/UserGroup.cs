using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Events.Models
{
    public class UserGroup
    {
        [Key]
        public long UserGroupID { get; set; }
        public long GroupID { get; set; }
        public long UserID { get; set; }
    }
}
