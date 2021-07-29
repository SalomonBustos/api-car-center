using AutoMapper;
using carCenter.dtos.clientes;
using carCenter.models.clientes;

namespace carCenter.mappings.clientes
{
    public class ClientesMapping : Profile
    {
        public ClientesMapping()
        {
            CreateMap<ClienteRequestCreate, ClienteEntity>();
            CreateMap<ClienteRequestUpdate, ClienteEntity>();
            CreateMap<ClienteEntity, ClienteResponse>();
        }

    }
}
