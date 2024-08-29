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
            public int RubroId { get; set; }

            [Required]
            public string PoliticaDevoluciones { get; set; }

            [Required]
            public string DirecciónComercial { get; set; }

            [Required]
            public string NumeroRegistroTributario { get; set; }

            [Required]
            public string ModoEnvioPreferido { get; set; }
            
            [Required]
            public string Nombre { get; set; }

            [Required]
            public string ApellidoPaterno { get; set; }

            [Required]
            public string ApellidoMaterno { get; set; }

            [Required]
            [EmailAddress]
            public string Correo { get; set; }
            public string RepetirCorreo { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Contraseña { get; set; }
            public string RepetirContraseña { get; set; }
            public string Telefono { get; set; }

            public string Direccion { get; set; }
        }

    
}
