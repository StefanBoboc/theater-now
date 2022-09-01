using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;
using TheaterNow.Repositories;
using TheaterNow.ViewModels;

namespace TheaterNow.Services
{
    public class ClientsService : IClientsService
    {
        private readonly IClientsRepository _clientsRepository;
        public ClientsService(IClientsRepository clientsRepository)
        {
            _clientsRepository = clientsRepository;
        }

        public List<Client> GetAllClients()
        {
            return _clientsRepository.GetAllClients().ToList();
        }

        public Client GetClientById(int clientId) => _clientsRepository.GetAllClients().FirstOrDefault(x => x.Id == clientId);

        public void AddClient(ClientVM client) 
        {
            var _client = new Client()
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,
                BirthDate = client.BirthDate
            };

            _clientsRepository.AddClient(_client);
        }

        public Client UpdateClientById(int clientId, ClientVM client) 
        {
            var _client = GetClientById(clientId);
            if (_client != null) 
            {
                _client.FirstName = client.FirstName;
                _client.LastName = client.LastName;
                _client.Email = client.Email;
                _client.BirthDate = client.BirthDate;

                _clientsRepository.UpdateClientById(_client);
            }

            return _client;
        }
        public Client DeleteClientById(int clientId) 
        { 
            var _client = GetClientById(clientId);
            if (_client != null)
            {
                _clientsRepository.DeleteClientById(_client);
            }
            return _client;
        }
    }
}
