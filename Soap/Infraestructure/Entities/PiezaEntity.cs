namespace Soap.Infraestructure.Entities
{
    public class PiezaEntity
    {
        public Guid? id { get; set; } 

        public string producto { get; set; } = null!;

        public string categoria { get; set; }  = null!;

        public decimal precio { get; set; } 

        public string descripcion { get; set; } = null!;

        public string codigo { get; set; }  = null!;

        public string marca { get; set; } = null!;

        public string stock { get; set; }  = null!;

        public string[] modelosvehiculos { get; set; } = Array.Empty<string>(); 
    }
}
