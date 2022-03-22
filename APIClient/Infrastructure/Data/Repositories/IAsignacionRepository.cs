using APIClient.Infrastructure.Data.Entities;
 
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIClient.Infrastructure.Data.Repositories
{
    public interface IAsignacionRepository
    {
        Task<Asignacion> DeleteAsync(string id);
        Task<Asignacion> GetAsignacionByIdAsync(string id);

        Task<Asignacion> GetAsignacionByMatriculaAsync(string matricula);
        
        Task<List<Asignacion>> GetAsignacionAsync();
        Task<Asignacion> InsertAsync(Asignacion asignacion);
        Task<Asignacion> UpdateAsync(string id, Asignacion asignacion);
    }
}