using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;

namespace TheaterNow.Repositories
{
    public interface IShowsRepository
    {
        IQueryable<Show> GetAllShows();
        void AddShow(Show show);
        void UpdateShowById(Show show);
        void DeleteShowById(Show show);
    }
}
