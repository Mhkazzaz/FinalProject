using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Role
    {
        public int id { get; set; }
        public string roleName { get; set; }
        public virtual ICollection<UserRoles> userRoles { get; set; }
    }
}