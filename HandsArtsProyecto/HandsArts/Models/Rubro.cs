namespace HandsArts.Models
{
    public class Rubro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Lista de empresas que pertenecen a este rubro
        public List<Empresa> Empresas { get; set; }
    }
}
