using OurHeroApiWithCodeFirstApproach.Entity;
//using OurHeroApiWithCodeFirstApproach.Entity;
using OurHeroApiWithCodeFirstApproach.Model;

namespace OurHeroApiWithCodeFirstApproach.Services
{
    public class OurHeroService : IOurHeroService
    {
        private readonly OurHeroDbContext _db;
        public OurHeroService(OurHeroDbContext db)
        {
            _db = db;


        }

        public Task<OurHero?> AddOurHero(AddUpdateOurHero obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHerosByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OurHero>> GetAllHeros(bool? isActive)
        {
            throw new NotImplementedException();
        }

        public Task<OurHero?> GetHerosByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OurHero?> UpdateOurHero(int id, AddUpdateOurHero obj)
        {
            throw new NotImplementedException();
        }
    }
}
