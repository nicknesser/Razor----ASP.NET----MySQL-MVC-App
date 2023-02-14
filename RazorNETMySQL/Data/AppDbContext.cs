using Microsoft.EntityFrameworkCore;

namespace RazorNETMySQL.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

    }
}
