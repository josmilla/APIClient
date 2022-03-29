using APIClient.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIClient.Infrastructure.Data.Repositories
{
    public interface IRolRepository
    {
        Task<Rol> DeleteAsync(int id);
        Task<Rol> GetRolByIdAsync(int id);
                    
        Task<List<Rol>> GetRolAsync();
        Task<Rol> InsertAsync(Rol rol);
        Task<Rol> UpdateAsync(int id, Rol rol);
    }
}