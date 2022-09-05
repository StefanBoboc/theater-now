using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;
using TheaterNow.ViewModels;

namespace TheaterNow.Services
{
    public interface IClientsService
    {
        List<Client> GetAllClients();
        Client GetClientById(int id);
        List<Client> GetClientsWithShows();
        void AddClient(ClientVM client);
        public Client UpdateClientById(int clientId, ClientVM client);
        public Client DeleteClientById(int clientId);
    }
}
