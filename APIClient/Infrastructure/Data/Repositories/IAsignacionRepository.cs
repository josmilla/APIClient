using APIClient.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIClient.Infrastructure.Data.Repositories
{
    public interface IAsignacionRepository
    {
        Task<Asignacion> DeleteAsync(Guid id);
        Task<Asignacion> GetAsignacionByIdAsync(Guid id);

                
        Task<List<Asignacion>> GetAsignacionAsync();
        Task<Asignacion> InsertAsync(Asignacion asignacion);
        Task<Asignacion> UpdateAsync(Guid id, Asignacion asignacion);
    }
}