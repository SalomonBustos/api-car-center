using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using carCenter.models.clientes;
using carCenter.models.dbcontext;
using Microsoft.EntityFrameworkCore;

namespace carCenter.repositories.clientes
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly CarCenterDbContext _context;

        public ClienteRepository(CarCenterDbContext context)
        {
            _context = context;
        }

        public async Task<ClienteEntity> Create(ClienteEntity entity)
        {
            var result = await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<ClienteEntity> Read(Guid id)
        {
            return await _context.Clientes.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<ClienteEntity> Update(ClienteEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<bool> Delete(Guid id)
        {
            var entity = await _context.Clientes.FindAsync(id);
            if (entity != null)
            {
                _context.Clientes.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public bool Exists(Guid id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }

        public async Task<List<ClienteEntity>> GetAll()
        {
            return await _context.Clientes.ToListAsync();
        }

    }
}
