using Clients.Domain.Entities;
using Clients.Domain.Interfaces;
using Clients.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Clients.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;
        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Client>> GetClientsAsync(string? identificacion, int pageNumber, int pageSize)
        {
            var identificacionParam = new SqlParameter("@Identificacion", identificacion ?? (object)DBNull.Value);
            var pageNumberParam = new SqlParameter("@PageNumber", pageNumber);
            var pageSizeParam = new SqlParameter("@PageSize", pageSize);

            return await _context.Clients
                .FromSqlRaw("EXEC sp_GetClients @Identificacion, @PageNumber, @PageSize", identificacionParam, pageNumberParam, pageSizeParam)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
