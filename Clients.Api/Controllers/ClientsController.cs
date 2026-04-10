using Clients.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clients.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetClients(
            [FromQuery] string? identificacion,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10)
        {
            pageNumber = pageNumber < 1 ? 1 : pageNumber;
            pageSize = pageSize < 1 ? 10 : pageSize;

            var clients = await _clientService.GetClientsAsync(identificacion, pageNumber, pageSize);
            if (clients == null || !clients.Any())
                return NotFound("No se encontraron clientes.");

            return Ok(clients);
        }
    }
}
