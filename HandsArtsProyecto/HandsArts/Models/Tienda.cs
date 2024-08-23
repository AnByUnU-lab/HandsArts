namespace HandsArts.Models
{
    public class Tienda
    {
        public int IdTienda { get; set; }
        public string NombreTienda { get; set; }
        public string DescripcionTienda { get; set; }
        public Category TipoCategoria { get; set; }
        public User RutTienda { get; }
    }
}