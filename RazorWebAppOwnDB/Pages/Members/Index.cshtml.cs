using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWebAppOwnDB.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorWebAppOwnDB.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly RazorWebAppOwnDB.Models.MemberContext _context;

        public IndexModel(RazorWebAppOwnDB.Models.MemberContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; }
        public string FirstSort { get; set; }
        public string LastSort { get; set; }
        public string DateSort { get; set; }
        public string MajorSort { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString, string searchCourse)
        {
            // LastSort set to last_sort if not null or empty
            LastSort = String.IsNullOrEmpty(sortOrder) ? "last_sort" : "";

            DateSort = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
            //DateSort = sortOrder == "Initiation Date" ? "date_desc" : ""; // : "Date";

            IQueryable<Member> memberIQ = from s in _context.Member
                                            select s;

            switch (sortOrder)
            {
                case "last_sort":
                    //memberIQ = memberIQ.OrderByDescending(s => s.LastName);
                    memberIQ = memberIQ.OrderBy(s => s.LastName);
                    break;
                case "date_desc":
                    memberIQ = memberIQ.OrderBy(s => s.InitiationDate);
                    break;
                default:
                    memberIQ = memberIQ.OrderBy(s => s.Major);
                    break;
            }

            // ************Searching/filtering***************

            // User entered first name to search by 
            if (!String.IsNullOrEmpty(searchString))
            {
                // Search first name
                memberIQ = memberIQ.Where(s => s.FirstName.Contains(searchString));
            }
            // First name search is empty, so just search courses 
            if (!String.IsNullOrEmpty(searchCourse))
            {
                 // Search courses 
                 memberIQ = memberIQ.Where(s => s.CurrentCourses.Contains(searchCourse));
             }

            //Member = await same.ToListAsync(); //_context.Member.ToListAsync();
            Member = await memberIQ.AsNoTracking().ToListAsync();
        }
    }
}
