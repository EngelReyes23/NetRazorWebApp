using Microsoft.EntityFrameworkCore;
using NetRazorWebApp.Models;

namespace NetRazorWebApp.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }


    public DbSet<Course> Course { get; set;}
    }
}
