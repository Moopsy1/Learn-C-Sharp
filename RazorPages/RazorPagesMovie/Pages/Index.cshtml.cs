using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesMovie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
            

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _logger.LogInformation("### Logger is created");
        }
        
        public void OnGet()
        {
            _logger.LogInformation("### we are in the OnGet() function of the RazorPagesMovie.Pages.IndexModel");
            //return RedirectToPage("./Movies/Index");
            _logger.LogInformation("### we are in the OnGet() and have called redirect");
        }
    }
}
