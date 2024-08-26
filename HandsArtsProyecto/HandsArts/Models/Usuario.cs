using System.ComponentModel.DataAnnotations;

namespace HandsArts.Models
{
    public abstract class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool EstadoVerificación { get; set; }
        public string Direccion { get; set; }
    }
}