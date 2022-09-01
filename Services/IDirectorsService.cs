using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;
using TheaterNow.ViewModels;

namespace TheaterNow.Services
{
    public interface IDirectorsService
    {
        List<Director> GetAllDirectors();
        Director GetDirectorById(int id);
        void AddDirector(DirectorVM director);
        public Director UpdateDirectorById(int directorId, DirectorVM director);
        public Director DeleteDirectorById(int directorId);
    }
}
