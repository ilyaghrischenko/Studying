using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WA_EF_4;
using WA_EF_4.Models;

namespace WA_EF_4.Pages.Instructors
{
    public class EditModel : InstructorCoursesPageModel
        {
            private readonly studContext _context;

            public EditModel(studContext context)
            {
                _context = context;
            }

            [BindProperty]
            public Instructor Instructor { get; set; }

            public async Task<IActionResult> OnGetAsync(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                Instructor = await _context.Instructors
                    .Include(i => i.Courses)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(m => m.ID == id);

                if (Instructor == null)
                {
                    return NotFound();
                }
            PopulateAssignedCourseData(_context, Instructor);
                return Page();
            }

        public async Task<IActionResult> OnPostAsync(int id, string[] selectedCourses)
        {
            var instructorToUpdate = await _context.Instructors
                .Include(i => i.Courses)
                .FirstOrDefaultAsync(s => s.ID == id);

            if (instructorToUpdate == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
                {
                
                UpdateInstructorCourses(selectedCourses, instructorToUpdate);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Index");
                }
            
            return Page();
            }

            public void UpdateInstructorCourses(string[] selectedCourses,
                                                Instructor instructorToUpdate)
            {
                if (selectedCourses == null)
                {
                    instructorToUpdate.Courses = new List<Course>();
                    return;
                }

                var selectedCoursesHS = new HashSet<string>(selectedCourses);
                var instructorCourses = new HashSet<int>
                    (instructorToUpdate.Courses.Select(c => c.CourseID));
                foreach (var course in _context.Courses)
                {
                    if (selectedCoursesHS.Contains(course.CourseID.ToString()))
                    {
                        if (!instructorCourses.Contains(course.CourseID))
                        {
                            instructorToUpdate.Courses.Add(course);
                        }
                    }
                    else
                    {
                        if (instructorCourses.Contains(course.CourseID))
                        {
                            var courseToRemove = instructorToUpdate.Courses.Single(
                                                            c => c.CourseID == course.CourseID);
                            instructorToUpdate.Courses.Remove(courseToRemove);
                        }
                    }
                }
            }
        
    }
}
