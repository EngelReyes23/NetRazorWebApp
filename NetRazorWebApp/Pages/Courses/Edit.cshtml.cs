using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetRazorWebApp.Data;
using NetRazorWebApp.Models;

namespace NetRazorWebApp.Pages.Courses
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public EditModel(ApplicationDBContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Course Course { get; set; }

        [TempData]
        public string Mensaje { get; set; }

        public async Task OnGet(int id)
        {
            Course = await _db.Course.FindAsync(id);
        }


        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var courseFromDb = await _db.Course.FindAsync(Course.Id);
                courseFromDb.CourseName = Course.CourseName;
                courseFromDb.QuantityClasses = Course.QuantityClasses;
                courseFromDb.Price = Course.Price;

                await _db.SaveChangesAsync();
                Mensaje = "Curso editado correctamente";
                return RedirectToPage("Index");
            }

            return RedirectToPage();
        }
    }
}
