using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;

namespace TheaterNow.Repositories
{
    public class ShowsRepository : IShowsRepository
    {
        private readonly AppDbContext _context;

        public ShowsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Show> GetAllShows()
        {
            var shows = _context.Shows;

            return shows;
        }

        public void AddShow(Show show)
        {
            _context.Shows.Add(show);
            _context.SaveChanges();
        }

        public void UpdateShowById(Show show)
        {
            _context.Shows.Update(show);

            _context.SaveChanges();
        }

        public void DeleteShowById(Show show)
        {
            _context.Shows.Remove(show);

            _context.SaveChanges();
        }
    }
}
