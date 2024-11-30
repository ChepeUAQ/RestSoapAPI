namespace Soap.Models
{
    public class PiezaModel
    {
        public Guid Id { get; set; }

        public string producto { get; set; } = string.Empty; 

        public string categoria { get; set; } = string.Empty; 

        public decimal precio { get; set; } 

        public string descripcion { get; set; } = string.Empty; 

        public string codigo { get; set; } = string.Empty; 

        public string marca { get; set; } = string.Empty; 

        public string stock { get; set; } = string.Empty; 

        public string[] modelosvehiculos { get; set; } = Array.Empty<string>(); 
    }
}
