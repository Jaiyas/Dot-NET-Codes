using Microsoft.EntityFrameworkCore;
using OurHeroApiWithCodeFirstApproach.Model;

namespace OurHeroApiWithCodeFirstApproach.Entity
{
    public class OurHeroDbContext:DbContext
    {
        public OurHeroDbContext(DbContextOptions<OurHeroDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting a primary key in OurHero model
            modelBuilder.Entity<OurHero>().HasKey(x => x.Id);

            // Inserting record in OurHero table
            modelBuilder.Entity<OurHero>().HasData(
                new OurHero
                {
                    Id = 1,
                    FirstName = "System",
                    LastName = "",
                    IsActive = true,
                }
            );
        }
    }
}
