namespace Parcial1_Prog3.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public double Precio { get; set; }

        public string Categoria { get; set; }

        public required string Marca { get; set; }

        public bool Favorito { get; set; }


    }
}
