using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Events.Models
{
    public class Group
    {
        [Key]
        public long GroupID { get; set; }
        [Required]
        [Display(Name ="Group Name")]
        public string GroupName { get; set; }
        
        public long OwnerID { get; set; }
        [Display(Name = "Group Owner")]
        public virtual User Owner { get; set; }
    }
}
