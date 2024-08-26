using System.ComponentModel.DataAnnotations;

namespace HandsArts.ViewModels
{
    public class EmpresaVM
    {
            [Required]
            public string RutEmpresa { get; set; }

            [Required]
            public string NombreEmpresa { get; set; }

            [Required]
            public string RazonSocial { get; set; }

            [Required]
            public string GiroComercial { get; set; }

            [Required]
            public string Rubro { get; set; }

            [Required]
            public string PoliticaDevoluciones { get; set; }

            [Required]
            public string SectorGeografico { get; set; }

            [Required]
            public string NumeroRegistroTributario { get; set; }

            [Required]
            public string ModoEnvioPreferido { get; set; }

            [Required]
            public string Nombre { get; set; }

            [Required]
            public string Apellido { get; set; }

            [Required]
            [EmailAddress]
            public string Correo { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Contraseña { get; set; }
            public string RepetirContraseña { get; set; }

            public string Telefono { get; set; }

            public string Direccion { get; set; }
        }

    
}
