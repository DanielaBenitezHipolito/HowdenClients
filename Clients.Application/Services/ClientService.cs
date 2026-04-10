using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients.Application.Interfaces;
using Clients.Application.DTOs;
using Clients.Domain.Interfaces;

namespace Clients.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<List<ClientDTO>> GetClientsAsync(string? identificacion, int pageNumber, int pageSize)
        {
            var clients = await _clientRepository.GetClientsAsync(identificacion, pageNumber, pageSize);

            return clients.Select(c => new ClientDTO
            {
                Id = c.Id,
                Identificacion = c.Identificacion,
                Nombres = c.Nombres,
                Apellidos = c.Apellidos,
                Correo = c.Correo,
                Telefono = c.Telefono
            }).ToList();
        }
    }
}
