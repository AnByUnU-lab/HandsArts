using System.ComponentModel.DataAnnotations;

namespace HandsArts.Models
{
    public class Empresa : Usuario
    {
        public string RutEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string RazonSocial { get; set; }
        public string GiroComercial { get; set; }
        public int RubroId { get; set; } // Foreing Key de rubro asociado a usaurio
        public Rubro Rubro { get; set; } 
        public int? TiendaId { get; set; } // foreing key FK de tienda asociada
        public Tienda Tienda { get; set; }
        public string PoliticaDevoluciones { get; set; }
        public string DirecciónComercial { get; set; }
        public string NumeroRegistroTributario { get; set; }
        public string ModoEnvioPreferido { get; set; }
        public bool EstadoVerificacion { get; set; }

    }
}
