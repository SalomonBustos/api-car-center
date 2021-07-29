using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using carCenter.dtos.clientes;
using carCenter.models.clientes;
using carCenter.repositories.clientes;

namespace carCenter.services.clientes
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ClienteResponse> Create(ClienteRequestCreate cliente)
        {
            ClienteEntity entity = _mapper.Map<ClienteRequestCreate, ClienteEntity>(cliente);
            entity = await _repository.Create(entity);
            ClienteResponse dto = _mapper.Map<ClienteEntity, ClienteResponse>(entity);
            return dto;
        }

        public async Task<ClienteResponse> Read(Guid id)
        {
            var entity = await _repository.Read(id);
            var dto = _mapper.Map<ClienteEntity, ClienteResponse>(entity);
            return dto;
        }

        public async Task<ClienteResponse> Update(ClienteRequestUpdate cliente)
        {
            ClienteEntity entity = _mapper.Map<ClienteRequestUpdate, ClienteEntity>(cliente);
            entity = await _repository.Update(entity);
            ClienteResponse dto = _mapper.Map<ClienteEntity, ClienteResponse>(entity);
            return dto;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.Delete(id);
        }

        public bool Exists(Guid id)
        {
            return _repository.Exists(id);
        }

        public async Task<List<ClienteResponse>> GetAll()
        {
            List<ClienteEntity> clientes = await _repository.GetAll();

            var items = _mapper.Map<List<ClienteEntity>, List<ClienteResponse>>(clientes);
            List<ClienteResponse> response = new List<ClienteResponse>(items);
            return response;
        }

    }
}
