using Clients.Application.DTOs;

namespace Clients.Application.Interfaces
{
    public interface IAuthService
    {
        LoginResponseDTO? Login(LoginRequestDTO request);
    }
}
