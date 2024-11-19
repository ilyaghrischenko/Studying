using DB;
using DB.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HW_7.Pages.JobSeekers;

public class IndexModel : PageModel
{
    private readonly WorkUAContext _context;

    public IndexModel(WorkUAContext context)
    {
        _context = context;
    }

    public List<JobSeeker> JobSeekers { get; set; }

    public async Task OnGetAsync()
    {
        JobSeekers = await _context.JobSeekers.Include(js => js.JobApplications)
            .ThenInclude(ja => ja.Job).ToListAsync();
    }
}
