using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmothieDelight_RecruitmentAssignment.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }
    }
}