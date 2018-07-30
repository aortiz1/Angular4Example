using System;
using System.Collections.Generic;

namespace Course.DataLayer.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public DateTime? Created { get; set; }
        public bool? Active { get; set; }
        public string AspNetUserId { get; set; }
    }
}
