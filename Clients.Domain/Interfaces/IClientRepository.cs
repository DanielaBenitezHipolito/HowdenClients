using Clients.Domain.Entities;

namespace Clients.Domain.Interfaces
{
    public interface IClientRepository
    {
        Task<List<Client>> GetClientsAsync(string? identificacion, int pageNumber, int pageSize);
    }
}
