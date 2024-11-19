using DB;
using DB.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HW_7.Pages.Employers;

public class IndexModel : PageModel
{
    private readonly WorkUAContext _context;

    public IndexModel(WorkUAContext context)
    {
        _context = context;
    }

    public List<Employer> Employers { get; set; }
    
    public async Task OnGetAsync()
    {
        Employers = await _context.Employers
            .Include(e => e.Branches)
            .Include(e => e.Jobs)
            .ToListAsync();
    }
}