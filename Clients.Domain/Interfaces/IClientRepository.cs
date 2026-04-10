using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients.Domain.Entities;

namespace Clients.Domain.Interfaces
{
    public interface IClientRepository
    {
        Task<List<Client>> GetClientsAsync(string? identificacion, int pageNumber, int pageSize);
    }
}
