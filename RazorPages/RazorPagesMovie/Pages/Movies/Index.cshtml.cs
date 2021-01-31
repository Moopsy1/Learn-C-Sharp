using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    //derived from page-model (razor page)
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(RazorPagesMovie.Data.RazorPagesMovieContext context, ILogger<IndexModel> logger)
        {
            //this is the dependency injection, allowing this Index model to use the context
            _logger = logger;
            _logger.LogInformation("logger created in the Razor");
            _context = context;
            _logger.LogInformation("context created");

        }

        public IList<Movie> Movie { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        /*        When a request is made for the page,
         the OnGetAsync method returns a list of movies to the Razor Page.
        On a Razor Page, OnGetAsync or OnGet is 
        called to initialize the state of the page.*/
        /*When OnGet returns void or OnGetAsync returns Task, no return statement is used.*/
        public async Task OnGetAsync()
        {
            //string name = MethodBase.GetCurrentMethod().Name;
            //cannot call the method name because it is async
            _logger.LogInformation("in the On GetAsync of {0}", this.GetType().FullName);
            _logger.LogInformation("OnGetAsync has recieved {0}", SearchString);


            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;




            //uses system.Linq
            //this query is only defined here and is actually run only on the toList call
            //the linq is filtered in the contains but is still not run
            var movies = from m in _context.Movie
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }


            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();

        }
    }
}
