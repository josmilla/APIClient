using Microsoft.EntityFrameworkCore;
using APIClient.Infrastructure.Data.Contexts;
using APIClient.Infrastructure.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace APIClient.Infrastructure.Data.Repositories
{
    public class RolRepository : IRolRepository
    {
        private AsignacionContext _context;
        private DbSet<Rol> _dbSet;
        public RolRepository(AsignacionContext context)
        {
            _context = context;
            _dbSet = context.Set<Rol>();
        }

        public async Task<List<Rol>> GetRolAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<Rol> GetRolByIdAsync(int id)
        {
            return await _dbSet.Where(p => p.IdRol == id).FirstOrDefaultAsync();
        }

        

        public async Task<Rol> InsertAsync(Rol rol)
        {
            _dbSet.Add(rol);
            await _context.SaveChangesAsync();
            return rol;
        }
        public async Task<Rol> UpdateAsync(int id, Rol rol)
        {
            Rol actualizarToUpdate = await GetRolByIdAsync(id);
            actualizarToUpdate.SqRol = rol.SqRol;
            actualizarToUpdate.RolInsourcing = rol.RolInsourcing;
            actualizarToUpdate.Especialidad = rol.Especialidad;
            actualizarToUpdate.FechaRegistro = rol.FechaRegistro;
            actualizarToUpdate.RolInsourcing = rol.RolInsourcing;
            actualizarToUpdate.UsuarioRegistro = rol.UsuarioRegistro;
            actualizarToUpdate.FechaModificacion = rol.FechaModificacion;
            actualizarToUpdate.UsuarioModificacion = rol.UsuarioModificacion;
            actualizarToUpdate.Estado = rol.Estado;
          


            _dbSet.Update(actualizarToUpdate);
            await _context.SaveChangesAsync();

            return actualizarToUpdate;
        }

        public async Task<Rol> DeleteAsync(int id)
        {
            Rol eliminarToDelete = await GetRolByIdAsync(id);

            _dbSet.Remove(eliminarToDelete);
            await _context.SaveChangesAsync();
            return eliminarToDelete;
        }
    }
}
