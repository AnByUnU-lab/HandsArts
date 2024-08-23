namespace HandsArts.Models
{
    public class TiendaCategory
    {
        public int RelacionTiendaId { get; set; }
        public Tienda Tienda { get; set; }

        public int RelacionCategoryId { get; set; }
        public Category Category { get; set; }
    }
}