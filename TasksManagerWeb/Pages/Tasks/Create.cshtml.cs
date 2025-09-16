using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TasksManagerWeb.Data;
using TasksManagerWeb.Models;

namespace TasksManagerWeb.Pages.Tasks
{
    public class CreateModel : PageModel
    {
        private readonly TaskDbContext _context;

        public CreateModel(TaskDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TaskItem TaskItem { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TaskItem.CreatedAt = DateTime.Now;
            TaskItem.IsCompleted = false;

            _context.Tasks.Add(TaskItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}