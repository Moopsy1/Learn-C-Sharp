using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IOU.Data;
using IOU.Models;

namespace IOU.Pages.Admin
{
    public class DetailsModel : PageModel
    {
        private readonly IOU.Data.IOUContext _context;

        public DetailsModel(IOU.Data.IOUContext context)
        {
            _context = context;
        }

        public Models.User User { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.ID == int.Parse(id));

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
