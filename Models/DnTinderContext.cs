using Microsoft.EntityFrameworkCore;

namespace DnTinder.Models {
    public class DnTinderContext : DbContext {
        public DnTinderContext(DbContextOptions<DnTinderContext> options) : base(options)
        {
            
        }

        public DbSet<Preference> Preferences {get; set;}
    }
}