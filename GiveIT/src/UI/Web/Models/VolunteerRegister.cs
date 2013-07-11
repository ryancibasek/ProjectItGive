using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    public class Volunteer : User
    {
        [Display(Name = "Hours a week you wish to Volunteer?")]
        [Required]
        [RegularExpression("^[1-40]{1,2}]")]
        public int VolunteerHours { get; set; }

        [Display(Name = "Skill Set")]
        [StringLength(200)]
        public string SkillSet { get; set; }
    }
}