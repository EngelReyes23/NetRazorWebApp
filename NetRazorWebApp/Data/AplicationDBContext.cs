using Microsoft.EntityFrameworkCore;

namespace NetRazorWebApp.Data
{
    public class AplicationDBContext: DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options): base(options)
        {
            
        }
    }
}
