namespace Soap.Models
{
    public class PiezaModel
    {
        public Guid Id { get; set; } // Identificador único

        public string producto { get; set; } = string.Empty; // Nombre del producto

        public string categoria { get; set; } = string.Empty; // Categoría del producto

        public decimal precio { get; set; } // Precio del producto

        public string descripcion { get; set; } = string.Empty; // Descripción del producto

        public string codigo { get; set; } = string.Empty; // Código único del producto

        public string marca { get; set; } = string.Empty; // Marca del producto

        public string stock { get; set; } = string.Empty; // Estado del stock (Disponible, Agotado, etc.)

        public string[] modelosvehiculos { get; set; } = Array.Empty<string>(); // Modelos de vehículos compatibles
    }
}
