using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorWebAppOwnDB.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MemberContext( 
                serviceProvider.GetRequiredService<DbContextOptions<MemberContext>>()))
            {
                // Look for any members 
                if (context.Member.Any())
                {
                    return;   // DB has been seeded already, so don't re-seed 
                }

                // Add members in database to begin with 
                context.Member.AddRange(
                    new Member
                    {
                        FirstName = "Brigit",
                        LastName = "Murtaugh",
                        InitiationDate = DateTime.Now,
                        Major = "Computer Science",
                        CurrentCourses = "Discrete, Senior Design, Databases",
                        Description = "I'm very busy this semester but will try to help with any CS classes",
                        EmailAddress = "bamurtaugh@yahoo.com"
                    },

                    new Member
                    {
                        FirstName = "Andres",
                        LastName = "Smith",
                        InitiationDate = DateTime.Now,
                        Major = "Electrical Engineering",
                        CurrentCourses = "Thermodynamics, Electrical Networks",
                        Description = "Able to help with Calc 1-3, Physics 1-3",
                        EmailAddress = "smitha@yahoo123.com"
                    },

                    new Member
                    {
                        FirstName = "Josh",
                        LastName = "Nick",
                        InitiationDate = DateTime.Now, //Convert.ToDateTime(4/10/2017),
                        Major = "Information Technology",
                        CurrentCourses = "Databases, Electrical Networks, Computer Science 1",
                        Description = "Probably can't help with much, but going to try",
                        EmailAddress = "EBuddyPro@gmail123.com"
                    },

                    new Member
                    {
                        FirstName = "Phil",
                        LastName = "Connor",
                        InitiationDate = DateTime.Now, // Convert.ToDateTime(11/14/2013),
                        Major = "Photonics",
                        CurrentCourses = "Senior Design, Flight Structures, Materials, Physics",
                        Description = "Strong at Freshman-Sophomore level material",
                        EmailAddress = "adamazo@gmail123.com"
                    },

                    new Member
                    {
                        FirstName = "Zoe",
                        LastName = "Adams",
                        InitiationDate = DateTime.Now, //Convert.ToDateTime(11/9/2015),
                        Major = "Aerospace Engineering",
                        CurrentCourses = "Flight Structures, Statics",
                        Description = "Willing to help lower level and do same-level study buddies",
                        EmailAddress = "zoegirl@gmail123.com"
                    },

                    new Member
                    {
                        FirstName = "Brigit",
                        LastName = "Ariel",
                        InitiationDate = DateTime.Now, //Convert.ToDateTime(4/10/2016),
                        Major = "Computer Engineering",
                        CurrentCourses = "Operating Systems, Discrete, Databases, Other",
                        Description = "Strongest at Java, C, and C#",
                        EmailAddress = "barielm@notrealemail.com"
                    },

                    new Member
                    {
                        FirstName = "Kenzie",
                        LastName = "Jess",
                        InitiationDate = DateTime.Now, //Convert.ToDateTime(4/10/2016),
                        Major = "Civil Engineering",
                        CurrentCourses = "Concrete, Thermodynamics, Physics, Senior Design, Other",
                        Description = "Really looking for study buddies, available most weekends.",
                        EmailAddress = "kjkj13@gmail123.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}