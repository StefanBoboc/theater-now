using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;
using TheaterNow.Repositories;
using TheaterNow.ViewModels;

namespace TheaterNow.Services
{
    public class ShowsService : IShowsService
    {
        private readonly IShowsRepository _showsRepository;
        public ShowsService(IShowsRepository showsRepository)
        {
            _showsRepository = showsRepository;
        }
        
        public List<Show> GetAllShows()
        {
            return _showsRepository.GetAllShows().ToList();
        }

        public Show GetShowById(int showId) => _showsRepository.GetAllShows().FirstOrDefault(x => x.Id == showId);

        public List<Show> GetShowsByTitle(string title) 
        {
            return _showsRepository.GetAllShows().Where(c => c.Title.ToUpper().Contains(title.ToUpper())).ToList();

        }

        public void AddShow(ShowVM show)
        {
            var _show = new Show()
            {
                Title = show.Title,
                Duration = show.Duration,
                Rating = show.Rating,
                ReleaseYear = show.ReleaseYear,
                Price = show.Price,
                DirectorId = show.DirectorId
            };

            _showsRepository.AddShow(_show);
        }

        public Show UpdateShowById(int showId, ShowVM show)
        {
            var _show = GetShowById(showId);
            if (_show != null)
            {
                _show.Title = show.Title;
                _show.Duration = show.Duration;
                _show.Rating = show.Rating;
                _show.ReleaseYear = show.ReleaseYear;
                _show.Price = show.Price;
                _show.DirectorId = show.DirectorId;

                _showsRepository.UpdateShowById(_show);
            }

            return _show;
        }
        public Show DeleteShowById(int showId)
        {
            var _show = GetShowById(showId);
            if (_show != null)
            {
                _showsRepository.DeleteShowById(_show);
            }
            return _show;
        }
    }
}
