using Microsoft.EntityFrameworkCore;

namespace CMS.Models
{
    public class databaseContext:DbContext
    {
        public databaseContext(DbContextOptions<databaseContext> dbct) : base(dbct)
        {

        }
        public DbSet<customer> customer { get; set; }

    }
}
