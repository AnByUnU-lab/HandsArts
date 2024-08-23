using System.ComponentModel.DataAnnotations;

namespace HandsArts.Models
{
    public class Category
    {
        public int IdCategory { get; set; }

        [Required]
        public string Name { get; set; }

        // Propiedad de navegación para RecetaCategory
        public virtual ICollection<TiendaCategory> TiendaCategories { get; set; } = new List<TiendaCategory>();
    }
}