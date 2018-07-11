using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorWebAppOwnDB.Models
{
    public class Member
    {
        // Each member added will have an ID, first and last names, initiation date, major, and at least 1 current course
        // Must also include a description about themselves and their email (but these only appear in "details," not main index)
        // Error message will pop up if user doesn't fill in one of the fields

        public int ID { get; set; } // required by database as primary key

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Member must have a first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Member must have a last name")]
        public string LastName { get; set; }

        [Display(Name = "Initiation Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Member must have an initiation date")]
        public DateTime InitiationDate { get; set; }

        [Required(ErrorMessage = "Member must have a major")]
        public string Major { get; set; }

        [Display(Name = "Current Courses")]
        [Required(ErrorMessage = "Member must be enrolled in at least 1 course")]
        public string CurrentCourses { get; set; }
        /*public IEnumerable<string> CurrentCourses { get; set; }

        public List<SelectListItem> Courses { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Calculus", Text = "Calculus" },
            new SelectListItem { Value = "Discrete", Text = "Discrete" },
            new SelectListItem { Value = "Physics", Text = "Physics"    },
            new SelectListItem { Value = "Senior Design", Text = "Senior Design" },
            new SelectListItem { Value = "Other", Text = "Other (Please Specify in Description)"  }
         };*/

        [Required(ErrorMessage = "Please add a short description (strongest classes, preferred study style, etc)")]
        public string Description { get; set; } // Only appears in "details" view of member

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please include an email so that other members can contact you")]
        public string EmailAddress { get; set; } // Also only appears in "details" view
    }
}
