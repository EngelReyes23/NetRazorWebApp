using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetRazorWebApp.Data;
using NetRazorWebApp.Models;

namespace NetRazorWebApp.Pages.Courses
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Course Course { get; set; }

        [TempData]
        public string Message { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Course.DateCreated = DateTime.Now;

            _db.Add(Course);
            await _db.SaveChangesAsync();
            Message = "Curso creado correctamente";
            return RedirectToPage("Index");
        }
    }
}
