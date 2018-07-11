using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWebAppOwnDB.Models;

namespace RazorWebAppOwnDB.Pages.Members
{
    public class DetailsModel : PageModel
    {
        private readonly RazorWebAppOwnDB.Models.MemberContext _context;

        public DetailsModel(RazorWebAppOwnDB.Models.MemberContext context)
        {
            _context = context;
        }

        public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Member = await _context.Member.SingleOrDefaultAsync(m => m.ID == id);

            if (Member == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
