using System;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoWrapper.Wrappers;
using carCenter.dtos.clientes;
using carCenter.services.clientes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace carCenter.Controllers
{
    [ApiController]
    [Route("api/v1/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClientesController(IClienteService service)
        {
            _service = service;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(ClienteRequestCreate cliente)
        {
            var response = await _service.Create(cliente);
            return Created("/api/v1/clientes/" + response.Id, new ApiResponse("Cliente creado.", response, 201));
        }

        [HttpGet("{clienteId}")]
        public async Task<IActionResult> Read(Guid clienteId)
        {
            var response = await _service.Read(clienteId);

            if (response != null)
            {
                return Ok(new ApiResponse("Cliente encontrado.", response, 200));
            }
            else
            {
                return NotFound(new ApiResponse("Cliente no encontrado.", null, 404));
            }
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(Guid id, [FromBody] ClienteRequestUpdate cliente)
        {
            if (cliente.Id != id)
            {
                return BadRequest(new ApiResponse("Cliente Id no coincide con el id a actualizar.", cliente, 404));
            }

            if (!_service.Exists(id))
            {
                return NotFound(new ApiResponse("El cliente a actualizar no existe", null, 404));
            }

            var response = await _service.Update(cliente);
            return Ok(new ApiResponse("Cliente actualizado.", response, 200));

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            ClienteResponse clienteExistente = await _service.Read(id);

            if (clienteExistente == null)
            {
                return BadRequest(new ApiResponse("El cliente a actualizar no existe", null, 400));
            }

            await _service.Delete(id);
            return Ok(new ApiResponse("Cliente eliminado.", null, 204));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {

            var response = await _service.GetAll();

            if (response.Count == 0)
            {
                return NotFound();
            }

            return Ok(response);
        }


    }
}
