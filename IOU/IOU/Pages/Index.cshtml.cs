using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOU.Models;
using Microsoft.AspNetCore.Http;

namespace IOU.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        private readonly IOU.Data.IOUContext _context;

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }

        [BindProperty]
        public Models.User user { get; set; }


        public IndexModel(ILogger<IndexModel> logger,
            IOU.Data.IOUContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            

            if (_context.User.SingleOrDefault(u => u.userName == Username && u.password == Password) != null)
            {
                user = _context.User.Single(user1 => user1.userName == Username);
                HttpContext.Session.SetString("username", user.userName);
                HttpContext.Session.SetString("user-type", user.userType.ToString());

                _logger.LogInformation("Found user of type {0}", user.userType.ToString());

                if (HttpContext.Session.GetString("user-type") == "admin")
                {
                    return RedirectToPage("./Admin/Index");
                }
                else if ((HttpContext.Session.GetString("user-type") == "user"))
                {
                    return RedirectToPage("./User/Index");
                }
                else
                {
                    return RedirectToPage("./Index");
                }

            }
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }

        
    }
}
