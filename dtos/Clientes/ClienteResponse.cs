using System;

namespace carCenter.dtos.clientes
{
    public class ClienteResponse
    {
        public Guid Id { get; set; }

        public String PrimerNombre { get; set; }

        public String SegundoNombre { get; set; }

        public String PrimerApellido { get; set; }

        public String SegundoApellido { get; set; }

        public String TipoDocumento { get; set; }

        public String Documento { get; set; }

        public String Celular { get; set; }

        public String Direccion { get; set; }

        public String CorreoElectronico { get; set; }
    }
}