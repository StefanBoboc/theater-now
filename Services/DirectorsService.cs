using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;
using TheaterNow.Repositories;
using TheaterNow.ViewModels;

namespace TheaterNow.Services
{
    public class DirectorsService : IDirectorsService
    {
        private readonly IDirectorsRepository _directorsRepository;
        public DirectorsService(IDirectorsRepository directorsRepository)
        {
            _directorsRepository = directorsRepository;
        }

        public List<Director> GetAllDirectors()
        {
            return _directorsRepository.GetAllDirectors().ToList();
        }

        public Director GetDirectorById(int directorId) => _directorsRepository.GetAllDirectors().FirstOrDefault(x => x.Id == directorId);

        public void AddDirector(DirectorVM director)
        {
            var _director = new Director()
            {
                FullName = director.FullName
            };

            _directorsRepository.AddDirector(_director);
        }

        public Director UpdateDirectorById(int directorId, DirectorVM director)
        {
            var _director = GetDirectorById(directorId);
            if (_director != null)
            {
                _director.FullName = director.FullName;

                _directorsRepository.UpdateDirectorById(_director);
            }

            return _director;
        }

        public Director DeleteDirectorById(int directorId)
        {
            var _director = GetDirectorById(directorId);
            if (_director != null)
            {
                _directorsRepository.DeleteDirectorById(_director);
            }
            return _director;
        }
    }
}
