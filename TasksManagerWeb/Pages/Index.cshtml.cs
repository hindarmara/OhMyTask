using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasksManagerWeb.Data;
using TasksManagerWeb.Models;

namespace TasksManagerWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TaskDbContext _context;

        public IndexModel(TaskDbContext context)
        {
            _context = context;
        }

        public IList<TaskItem> Tasks { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Tasks = await _context.Tasks.OrderBy(t => t.IsCompleted).ThenByDescending(t => t.CreatedAt).ToListAsync();
        }

        public async Task<IActionResult> OnPostCompleteAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                task.IsCompleted = true;
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}