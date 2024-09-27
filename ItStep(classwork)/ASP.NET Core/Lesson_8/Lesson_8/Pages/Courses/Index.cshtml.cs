using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WA_EF_4;
using WA_EF_4.Models;

namespace WA_EF_4.Pages.Courses
{
    public class IndexModel : PageModel
    {

        private readonly studContext _context;

        public IndexModel(studContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get;set; }
        public IList<Department> Departments { get; set; }
        public int CourseID { get; set; }

        public async Task OnGetAsync(int? id, int? studentID)
        {
            Courses = await _context.Courses
                .Include(c => c.Department)
                .ToListAsync();
            Departments = await _context.Departments
                .ToListAsync();

            if (id != null)
            {
                CourseID = id.Value;
                var course = Courses
                    .Where(x => x.CourseID == id)
                    .Single();

                var students = await _context.Courses
                    .First(x => x.CourseID == id).Enrollments
                    .ToList()
                    .Select(x => x.Student)
                    .ToListAsync();
            }
        }
        
        // public async Task OnGetAsync()
        // {
        //
        //     Courses = await _context.Courses
        //         .Include(c => c.Department)
        //         .AsNoTracking()
        //         .ToListAsync();
        //
        //
        //
        // //    //Explicit loading(явная)
        // //    Courses = await _context.Courses.ToListAsync();
        // //    foreach (var c in Courses)
        // //    {
        // //        _context.Entry(c).Reference(p => p.Department).Load();
        //
        //     //    }
        //
        //
        //     }

        //public IList<CourseViewModel> CourseVM { get; set; }
        //public async Task OnGetAsync()
        //{
        //    //Lazy loading - ленивая загрузка
        //    CourseVM = await _context.Courses
        //    .Select(p => new CourseViewModel
        //    {
        //        CourseID = p.CourseID,
        //        Title = p.Title,
        //        Credits = p.Credits,
        //        DepartmentName = p.Department.Name
        //    }).ToListAsync();
        //}


    }
}


