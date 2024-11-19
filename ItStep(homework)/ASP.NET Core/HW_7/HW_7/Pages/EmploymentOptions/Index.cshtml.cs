using DB;
using DB.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HW_7.Pages.EmploymentOptions;

public class IndexModel : PageModel
{
    private readonly WorkUAContext _context;

    public IndexModel(WorkUAContext context)
    {
        _context = context;
    }

    public List<JobApplication> JobApplications { get; set; }

    public async Task OnGetAsync()
    {
        JobApplications = await _context.JobApplications
            .Include(ja => ja.JobSeeker)
            .Include(ja => ja.Job)
            .ToListAsync();
    }
}
