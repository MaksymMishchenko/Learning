using System.Collections;
using ClientsApp.Interfaces;
using ClientsApp.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace ClientsApp.Mocks
{
    public class ClientRepository : IClientRepository
    {
        private readonly DbClients _db;

        public ClientRepository(DbClients clients)
        {
            _db = clients;
        }

        public IEnumerable<Client> GetClientsLeftJoin { get; set; }
        public IEnumerable<Client> GetClientsByInnerJoin { get; set; }

        public IEnumerable<Client> GetClientsByCity => from client in _db.Clients.Include(p => p.CityId)
            where client.CityId.Id == 1 select client;

        public IEnumerable<Client> GetClientGroupBy { get; }

    }
}
