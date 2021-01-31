using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IOU.Data;
using IOU.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace IOU.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly IOU.Data.IOUContext _context;
        private readonly ILogger<Pages.IndexModel> _logger;


        public IndexModel(ILogger<Pages.IndexModel> logger, IOU.Data.IOUContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IList<Models.User> User { get; set; }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("user-type") == "admin")
            {
                _logger.LogInformation("admin user found User of type {0}", HttpContext.Session.GetString("user-type"));
                FillList();
                return Page();
            }
            else
            {
                _logger.LogInformation("wrong user-type found redirecting");
                return RedirectToPage("../Index");
            }

        }

        public void FillList()
        {
            User =  _context.User.ToList();
        }
    }
}
