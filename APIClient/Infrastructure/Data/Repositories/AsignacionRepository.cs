using Microsoft.EntityFrameworkCore;
using APIClient.Infrastructure.Data.Contexts;
using APIClient.Infrastructure.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIClient.Infrastructure.Data.Repositories
{
    public class AsignacionRepository : IAsignacionRepository
    {
        private AsignacionContext _context;
        private DbSet<Asignacion> _dbSet;
        public AsignacionRepository(AsignacionContext context)
        {
            _context = context;
            _dbSet = context.Set<Asignacion>();
        }

        public async Task<List<Asignacion>> GetAsignacionAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<Asignacion> GetAsignacionByIdAsync(string id)
        {
            return await _dbSet.Where(p => p.id == id).FirstOrDefaultAsync();
        }

        public async Task<Asignacion> GetAsignacionByMatriculaAsync(string matricula)
        {
            return await _dbSet.Where(p => p.Matricula == matricula).FirstOrDefaultAsync();
        }

        public async Task<Asignacion> InsertAsync(Asignacion asignacion)
        {
            _dbSet.Add(asignacion);
            await _context.SaveChangesAsync();
            return asignacion;
        }
        public async Task<Asignacion> UpdateAsync(string id, Asignacion asignacion)
        {
            Asignacion asignacionToUpdate = await GetAsignacionByIdAsync(id);
            asignacionToUpdate.Matricula   = asignacion.Matricula;
            asignacionToUpdate.Nombres = asignacion.Nombres;
            asignacionToUpdate.ApellidoPaterno = asignacion.ApellidoPaterno;
            asignacionToUpdate.ApellidoMaterno = asignacion.ApellidoMaterno;
            asignacionToUpdate.Rol = asignacion.Rol;
            asignacionToUpdate.RolInsourcing = asignacion.RolInsourcing;
            asignacionToUpdate.CodApp = asignacion.CodApp;
            asignacionToUpdate.Asignar = asignacion.Asignar;
            asignacionToUpdate.FechaRegistro = asignacion.FechaRegistro;

            _dbSet.Update(asignacionToUpdate);
            await _context.SaveChangesAsync();

            return asignacionToUpdate;
        }

        public async Task<Asignacion> DeleteAsync(string id)
        {
            Asignacion asignacionToDelete = await GetAsignacionByIdAsync(id);

            _dbSet.Remove(asignacionToDelete);
            await _context.SaveChangesAsync();
            return asignacionToDelete;
        }
    }
}
