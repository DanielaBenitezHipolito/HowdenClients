using Clients.Application.DTOs;

namespace Clients.Application.Interfaces
{
    public interface IClientService
    {
        Task<List<ClientDTO>> GetClientsAsync(string? identificacion, int pageNumber, int pageSize);
    }
}
