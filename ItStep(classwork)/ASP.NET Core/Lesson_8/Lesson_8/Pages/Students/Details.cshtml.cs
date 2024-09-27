using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WA_EF_4.Models;
using WA_EF_4;

namespace WA_EF_4.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly studContext _context;

        public DetailsModel(studContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        //public async Task<IActionResult> OnGetAsync(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    Student = await _context.Students.FirstOrDefaultAsync(m => m.ID == id);

        //    if (Student == null)
        //    {
        //        return NotFound();
        //    }
        //    return Page();
        //}
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound("Id not");
            }

            Student = await _context.Students
                  .Include(s => s.Enrollments)
                  .ThenInclude(e => e.Course)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound("Not founf");
            }
            return Page();
        }
    }
}
