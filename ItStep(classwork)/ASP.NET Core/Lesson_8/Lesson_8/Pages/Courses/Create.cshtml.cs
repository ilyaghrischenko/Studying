using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using WA_EF_4.Models;
using Microsoft.AspNetCore.Http;
using WA_EF_4;

namespace WA_EF_4.Pages.Courses
{
    public class CreateModel : DepartmentNamePageModel
    {
        private readonly studContext _context;

        public CreateModel(studContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateDepartmentsDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                PopulateDepartmentsDropDownList(_context, Course.DepartmentID);
                return Page();
            }

            _context.Courses.Add(Course);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");

        }
    }
}