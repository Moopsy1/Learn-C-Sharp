using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOU.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace IOU.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;
        private readonly IOU.Data.IOUContext _context;

        public string Username { get; set; }
        public string Password { get; set; }

        public string Message { get; set; }

        public Models.User User { get; set; }

        public LoginModel(ILogger<LoginModel> logger,
            IOU.Data.IOUContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

            _logger.LogInformation("we are in the Login page");
            //return Page();

        }

        public IActionResult OnPost()
        {
            if (Username.Equals("abc") && Password.Equals("123"))
            {
                HttpContext.Session.SetString("username", Username);
                return RedirectToPage("./Privacy");
            }
            else
            {
                Message = "Invalid Username or Password";
                return Page();
            }



        }

    }
}
