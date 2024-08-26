using System.ComponentModel.DataAnnotations;

namespace HandsArts.Models
{
    public class Empresa : Usuario
    {
        public string RutEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string RazonSocial { get; set; }
        public string GiroComercial { get; set; }
        public string Rubro { get; set; }
        public int? IDTienda { get; set; } // foreing key FK de tienda asociada
        public string PoliticaDevoluciones { get; set; }
        public string SectorGeografico { get; set; }
        public string NumeroRegistroTributario { get; set; }
        public string ModoEnvioPreferido { get; set; }
        public bool EstadoVerificacion { get; set; }

    }
}
