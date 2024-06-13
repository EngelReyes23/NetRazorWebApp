using System.ComponentModel.DataAnnotations;

namespace NetRazorWebApp.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Course Name")]
        public required string CourseName { get; set; }

        [Display(Name = "Quantity of Classes")]
        public int QuantityClasses { get; set; }

        [Display(Name = "Price of the course")]
        public double Price { get; set; }

        [Display(Name = "Date of Creation")]
        public required DateTime DateCreated { get; set; }
    }
}
