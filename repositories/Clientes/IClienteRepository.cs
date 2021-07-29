using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using carCenter.models.clientes;

namespace carCenter.repositories.clientes
{
    public interface IClienteRepository
    {
        Task<ClienteEntity> Create(ClienteEntity entity);
        Task<ClienteEntity> Read(Guid id);
        Task<ClienteEntity> Update(ClienteEntity entity);
        Task<bool> Delete(Guid id);
        bool Exists(Guid id);
        Task<List<ClienteEntity>> GetAll();
    }
}
