using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class UserRoles
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int roleId { get; set; }
        public virtual User user { get; set; }
        public virtual Role role { get; set; }
    }
}