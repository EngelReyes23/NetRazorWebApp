using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetRazorWebApp.Data;
using NetRazorWebApp.Models;

namespace NetRazorWebApp.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }

        [TempData]
        public string Message { get; set; }

        public IEnumerable<Course> Courses { get; set; }

        public async Task OnGet()
        {
            Courses = await _db.Course.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var course = await _db.Course.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            _db.Course.Remove(course);
            await _db.SaveChangesAsync();

            Message = "Deleted course correctly";

            return RedirectToPage("Index");
        }
    }
}
