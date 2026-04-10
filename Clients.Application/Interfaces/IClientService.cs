using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients.Application.DTOs;

namespace Clients.Application.Interfaces
{
    public interface IClientService
    {
        Task<List<ClientDTO>> GetClientsAsync(string? identificacion, int pageNumber, int pageSize);
    }
}
