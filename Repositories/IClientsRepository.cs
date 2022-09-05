using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;
using TheaterNow.ViewModels;

namespace TheaterNow.Repositories
{
    public interface IClientsRepository
    {
        IQueryable<Client> GetAllClients();
        IQueryable<Client> GetClientsWithShows();
        void AddClient (Client client);
        void UpdateClientById(Client client);
        void DeleteClientById(Client client);
    }
}
