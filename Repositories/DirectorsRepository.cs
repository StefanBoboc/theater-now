using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;

namespace TheaterNow.Repositories
{
    public class DirectorsRepository : IDirectorsRepository
    {
        private readonly AppDbContext _context;

        public DirectorsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Director> GetAllDirectors()
        {
            var directors = _context.Directors;

            return directors;
        }

        public void AddDirector(Director director)
        {
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public void UpdateDirectorById(Director director)
        {
            _context.Directors.Update(director);

            _context.SaveChanges();
        }

        public void DeleteDirectorById(Director director)
        {
            _context.Directors.Remove(director);

            _context.SaveChanges();
        }
    }
}
