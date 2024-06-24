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
    public class DetailsModel : PageModel
    {
        private readonly Lesson_6.Data.MovieContext _context;

        public DetailsModel(Lesson_6.Data.MovieContext context)
        {
            _context = context;
        }

        public Models.Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
