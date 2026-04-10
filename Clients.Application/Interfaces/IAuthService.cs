using Clients.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Application.Interfaces
{
    public interface IAuthService
    {
        LoginResponseDTO? Login(LoginRequestDTO request);
    }
}
