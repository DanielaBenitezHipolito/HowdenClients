using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Domain.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(string username);
    }
}
