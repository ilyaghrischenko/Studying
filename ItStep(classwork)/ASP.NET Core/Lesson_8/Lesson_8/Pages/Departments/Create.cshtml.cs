using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WA_EF_4.Models;
using WA_EF_4;

namespace WA_EF_4_04._10.Pages.Departments
{
    public class CreateModel : PageModel
    {
        private readonly studContext _context;

        public CreateModel(studContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["InstructorID"] = new SelectList(_context.Set<Instructor>(), "ID", "FirstMidName");
            return Page();
        }

        [BindProperty]
        public Department Department { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Departments.Add(Department);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
