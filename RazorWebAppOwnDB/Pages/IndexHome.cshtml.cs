using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorWebAppOwnDB.Models;

namespace RazorWebAppOwnDB.Pages
//namespace RazorWebAppOwnDB.Pages.Members
// *********DON'T WANT THIS CLASS EDITED; WAS SUPPOSED TO BE OTHER INDEX CLASS
{
    public class IndexModel : PageModel
    {
        private readonly RazorWebAppOwnDB.Models.MemberContext _context;

        public IndexModel(RazorWebAppOwnDB.Models.MemberContext context)
        {
            _context = context;
        }

        // Search for certain members (first name, current courses, initiation date)
        // Search criteria to find a member you know or who could likely help you
        public IList<Member> Member { get; set; }
        public IList<Member> SameClasses { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            var sameFirst = from m in _context.Member
                            select m;
            //var sameClass = from m in _context.Member
                         //select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                // Search first names
                sameFirst = sameFirst.Where(s => s.FirstName.Contains(searchString));
            }

           /* if (!String.IsNullOrEmpty(sameClasses))
            {
                // Search courses 
                sameClass = sameClass.Where(s => s.CurrentCourses.Contains(searchString));
            }*/

            Member = await sameFirst.ToListAsync(); //_context.Member.ToListAsync();
            //SameClasses = await sameClass.ToListAsync(); //_context.Member.ToListAsync();
        }
    }
}
