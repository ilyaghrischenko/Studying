using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lesson_6.Data;
using Lesson_6.Models;

namespace Lesson_6.Pages.Movie
{
    public class IndexModel : PageModel
    {
        private readonly Lesson_6.Data.MovieContext _context;

        public IndexModel(Lesson_6.Data.MovieContext context)
        {
            _context = context;
        }

        public IList<Models.Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }
    }
}
