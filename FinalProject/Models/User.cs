using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}