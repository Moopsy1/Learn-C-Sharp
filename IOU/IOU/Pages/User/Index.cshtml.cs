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

namespace IOU.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<Pages.IndexModel> _logger;
        private readonly IOU.Data.IOUContext _context;

        public IndexModel(IOU.Data.IOUContext context,
            ILogger<Pages.IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public string Debtor { get; set; }
        [BindProperty(SupportsGet = true)]
        public decimal Amount { get; set; }


        public IList<IOUSlip> IOUSlip { get; set; }

        public async Task OnGetAsync()
        {
            _logger.LogInformation($" Get We have received Debtor = {Debtor} and Amount = {Amount}");

            //check if current user is in the user context
            //if not return
            //check if debtor has an open IOU
            //if open IOU update value
            //add new IOU

            if (_context.User.SingleOrDefault(u => u.userName == HttpContext.Session.GetString("username")) == null)
            {
                Page();
            }

            IQueryable<string> Debtors = from d in _context.IOUSlip
                                         orderby d.Debtor
                                         select d.Debtor;

            if (Debtors.Contains(Debtor))
            {
                IOUSlip slip = _context.IOUSlip.SingleOrDefault(i => i.Debtor == Debtor);
                slip.Amount += Amount;
                await _context.SaveChangesAsync();
            }
            else
            {
                IOUSlip slip = new IOUSlip
                    {Amount = Amount, Debtor = Debtor, Owner = HttpContext.Session.GetString("username")};
                _context.IOUSlip.Add(slip);
                await _context.SaveChangesAsync();
            }

            IOUSlip = await _context.IOUSlip.Where(i => i.Owner == HttpContext.Session.GetString("username")).ToListAsync();


        }



    }
}
