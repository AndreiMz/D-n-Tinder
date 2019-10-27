using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DnTinder.Models {
    public class DnTinderContext : IdentityDbContext {
        public DnTinderContext(DbContextOptions<DnTinderContext> options) : base(options)
        {
            
        }

        public DbSet<Preference> Preferences {get; set;}
        public DbSet<Bug> Bugs{get; set;}
    }
}