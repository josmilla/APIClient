using Microsoft.EntityFrameworkCore;
using APIClient.Infrastructure.Data.Contexts;
using APIClient.Infrastructure.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace APIClient.Infrastructure.Data.Repositories
{
    public class AplicativoRepository : IAplicativoRepository
    {
        private AsignacionContext _context;
        private DbSet<Aplicativo> _dbSet;
        public AplicativoRepository(AsignacionContext context)
        {
            _context = context;
            _dbSet = context.Set<Aplicativo>();
        }

        public async Task<List<Aplicativo>> GetAplicativoAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<Aplicativo> GetAplicativoByIdAsync(int id)
        {
            return await _dbSet.Where(p => p.IdAplicativo == id).FirstOrDefaultAsync();
        }

        

        public async Task<Aplicativo> InsertAsync(Aplicativo squad)
        {
            _dbSet.Add(squad);
            await _context.SaveChangesAsync();
            return squad;
        }
        public async Task<Aplicativo> UpdateAsync(int id, Aplicativo aplicativo)
        {

            Aplicativo actualizarToUpdate = await GetAplicativoByIdAsync(id);
          
            actualizarToUpdate.CodAplicativo = aplicativo.CodAplicativo;
            actualizarToUpdate.NombreAplicativo = aplicativo.NombreAplicativo;
            actualizarToUpdate.BiddingblockAplicativo = aplicativo.BiddingblockAplicativo;
            actualizarToUpdate.EstadoAplicativo = aplicativo.EstadoAplicativo;
            actualizarToUpdate.IdPeriodo = aplicativo.IdPeriodo;
            actualizarToUpdate.FechaRegistro = aplicativo.FechaRegistro;
            actualizarToUpdate.UsuarioRegistro = aplicativo.UsuarioRegistro;
            actualizarToUpdate.FechaModificacion = aplicativo.FechaModificacion;
            actualizarToUpdate.UsuarioModificacion = aplicativo.UsuarioModificacion;
            actualizarToUpdate.Estado = aplicativo.Estado;
          


            _dbSet.Update(actualizarToUpdate);
            await _context.SaveChangesAsync();

            return actualizarToUpdate;
        }

        public async Task<Aplicativo> DeleteAsync(int id)
        {
            Aplicativo eliminarToDelete = await GetAplicativoByIdAsync(id);

            _dbSet.Remove(eliminarToDelete);
            await _context.SaveChangesAsync();
            return eliminarToDelete;
        }
    }
}
