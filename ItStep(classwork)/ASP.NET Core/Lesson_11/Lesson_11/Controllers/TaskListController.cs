using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lesson_11.Controllers;

public class TaskListController : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        using var context = new TasksContext();
        var dates = await context.MyDates.ToListAsync();

        return View(dates);
    }

    [HttpGet]
    public async Task<IActionResult> Show(int? id)
    {
        using var context = new TasksContext();
        var tasks = await context.MyTasks
            .Where(x => x.Date.Id == id)
            .ToListAsync();

        return View(tasks);
    }
}