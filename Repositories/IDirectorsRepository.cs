using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;

namespace TheaterNow.Repositories
{
    public interface IDirectorsRepository
    {
        IQueryable<Director> GetAllDirectors();
        void AddDirector(Director director);
        void UpdateDirectorById(Director director);
        void DeleteDirectorById(Director director);
    }
}
