using Clients.Application.DTOs;
using Clients.Application.Interfaces;
using Clients.Domain.Interfaces;

namespace Clients.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly ITokenService _tokenService;
        public AuthService(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }
        public LoginResponseDTO? Login(LoginRequestDTO request)
        {
            if (request.Username == "admin" && request.Password == "password")
            {
                var token = _tokenService.GenerateToken(request.Username);
                return new LoginResponseDTO
                {
                    Token = token
                };
            }
            return null;
        }

    }
}
