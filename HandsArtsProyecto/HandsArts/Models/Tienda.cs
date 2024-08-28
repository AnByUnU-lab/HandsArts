namespace HandsArts.Models
{
    public class Tienda
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaCreacion { get; set; }

        // Clave foránea hacia Empresa
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; } // Navegación hacia la empresa asociada
    }
}