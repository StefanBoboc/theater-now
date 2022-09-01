using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;
using TheaterNow.ViewModels;

namespace TheaterNow.Services
{
    public interface IShowsService
    {
        List<Show> GetAllShows();
        Show GetShowById(int id);
        void AddShow(ShowVM show);
        public Show UpdateShowById(int showId, ShowVM show);
        public Show DeleteShowById(int showId);
    }
}
