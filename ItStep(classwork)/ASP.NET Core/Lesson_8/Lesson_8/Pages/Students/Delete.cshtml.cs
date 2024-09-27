using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WA_EF_4.Models;
using WA_EF_4;
using Microsoft.Extensions.Logging;

namespace WA_EF_4.Pages.Students
{
    //public class DeleteModel : PageModel
    //{
    //    private readonly studContext _context;

    //    public DeleteModel(studContext context)
    //    {
    //        _context = context;
    //    }

    //    [BindProperty]
    //    public Student Student { get; set; }

    //    public async Task<IActionResult> OnGetAsync(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        Student = await _context.Students.FirstOrDefaultAsync(m => m.ID == id);

    //        if (Student == null)
    //        {
    //            return NotFound();
    //        }
    //        return Page();
    //    }

    //    public async Task<IActionResult> OnPostAsync(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        Student = await _context.Students.FindAsync(id);

    //        if (Student != null)
    //        {
    //            _context.Students.Remove(Student);
    //            await _context.SaveChangesAsync();
    //        }

    //        return RedirectToPage("./Index");
    //    }
    //}

    public class DeleteModel : PageModel
    {
        private readonly studContext _context;
        private readonly ILogger<DeleteModel> _logger;

        public DeleteModel(studContext context,
                           ILogger<DeleteModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        [BindProperty]
        public Student Student { get; set; }
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (saveChangesError==true)
            {
                ErrorMessage = String.Format("Delete {id} failed. Try again", id);
                return Page();
            }

            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }

            return Page();

            
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound("Пользователь не указан");
            }

            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound("Пользователя не существует");
            }

            try
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, ErrorMessage);

                return RedirectToAction("./Delete",
                                     new { id, saveChangesError = true });
            }
        }
    }
}
