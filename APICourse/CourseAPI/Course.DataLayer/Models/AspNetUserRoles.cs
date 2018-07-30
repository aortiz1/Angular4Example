using System;
using System.Collections.Generic;

namespace Course.DataLayer.Models
{
    public partial class AspNetUserRoles
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }
    }
}
