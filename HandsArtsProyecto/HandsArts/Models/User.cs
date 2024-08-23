using System.ComponentModel.DataAnnotations;

namespace HandsArts.Models
{
    public class User
    {
        public int IdUser { get; set; } // Este campo será autoincrementable por defecto

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        public string Rut { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}