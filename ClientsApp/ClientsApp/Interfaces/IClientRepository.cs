using ClientsApp.Models;
using System.Collections.Generic;

namespace ClientsApp.Interfaces
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetClientsLeftJoin { get; }
        IEnumerable<Client> GetClientsByInnerJoin { get; }
        IEnumerable<Client> GetClientsByCity { get; }
        IEnumerable<Client> GetClientGroupBy { get; }
    }
}
