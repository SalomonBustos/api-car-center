using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carCenter.models.clientes
{
    [Table(name: "clientes")]
    public class ClienteEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "id")]
        public Guid Id { get; set; }

        [Column(name: "primer_nombre", TypeName = "Varchar (255)")]
        public String PrimerNombre { get; set; }

        [Column(name: "segundo_nombre", TypeName = "Varchar (255)")]
        public String SegundoNombre { get; set; }

        [Column(name: "primer_apellido", TypeName = "Varchar (255)")]
        public String PrimerApellido { get; set; }

        [Column(name: "segundo_apellido", TypeName = "Varchar (255)")]
        public String SegundoApellido { get; set; }

        [Column(name: "tipo_documento", TypeName = "Varchar (255)")]
        public String TipoDocumento { get; set; }

        [Column(name: "documento", TypeName = "Varchar (20)")]
        public String Documento { get; set; }

        [Column(name: "celular", TypeName = "Varchar (20)")]
        public String Celular { get; set; }

        [Column(name: "direccion", TypeName = "Varchar (255)")]
        public String Direccion { get; set; }

        [Column(name: "correo_electronico", TypeName = "Varchar (255)")]
        public String CorreoElectronico { get; set; }
    }
}
