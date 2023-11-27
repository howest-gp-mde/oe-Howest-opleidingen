using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SP.Api.Entities;

namespace SP.Api.Data
{
    public class SPContext: IdentityDbContext<ApplicationUser>
    {

        public DbSet<StudyProgramme> StudyProgrammes { get; set;}

        public SPContext(DbContextOptions<SPContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            Seeder.Seed(builder);
        }
    }
}
