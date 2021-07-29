using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using carCenter.dtos.clientes;

namespace carCenter.services.clientes
{
    public interface IClienteService
    {
        Task<ClienteResponse> Create(ClienteRequestCreate cliente);
        Task<ClienteResponse> Read(Guid id);
        Task<ClienteResponse> Update(ClienteRequestUpdate cliente);
        Task<bool> Delete(Guid id);
        bool Exists(Guid id);
        Task<List<ClienteResponse>> GetAll();
    }
}
