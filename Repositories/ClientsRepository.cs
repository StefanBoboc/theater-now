using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterNow.Entities;

namespace TheaterNow.Repositories
{
    public class ClientsRepository : IClientsRepository
    {
        private readonly AppDbContext _context;

        public ClientsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Client> GetAllClients()
        {
            var clients = _context.Clients;

            return clients;
        }

        public void AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void UpdateClientById(Client client)
        {
            _context.Clients.Update(client);

            _context.SaveChanges();
        }

        public void DeleteClientById(Client client)
        {
            _context.Clients.Remove(client);

            _context.SaveChanges();
        }
    }
}
