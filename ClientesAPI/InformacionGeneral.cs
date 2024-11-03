using System;

namespace ClienteApi.Models
{
    public class InformacionGeneral
    {
        public int Id { get; set; }
        public string TipoInformacion { get; set; } // "DIRECCION", "CONTABILIDAD", "INFORMACION FINANCIERA"
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreador { get; set; }
        public bool EstadoInformacion { get; set; }

        // Campos de Información Financiera
        public decimal Campo1 { get; set; }
        public decimal Campo2 { get; set; }
        public decimal Campo3 { get; set; }
        public decimal Campo4 { get; set; }
        public decimal Campo5 { get; set; }
    }
}
