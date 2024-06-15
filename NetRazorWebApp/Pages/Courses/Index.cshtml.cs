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

        public IEnumerable<Course> Courses { get; set; }

        public async Task OnGet()
        {
            Courses = await _db.Course.ToListAsync();
        }
    }
}
