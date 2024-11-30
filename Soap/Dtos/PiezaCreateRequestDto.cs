using System.Runtime.Serialization;

namespace Soap.Dtos
{
    [DataContract]
    public class PiezaCreateRequestDto
    {

        [DataMember]
        public string producto { get; set; } = string.Empty;

        [DataMember]
        public string categoria { get; set; } = string.Empty;

        [DataMember]
        public decimal precio { get; set; }

        [DataMember]
        public string descripcion { get; set; } = string.Empty;

        [DataMember]
        public string codigo { get; set; } = string.Empty;

        [DataMember]
        public string marca { get; set; } = string.Empty;

        [DataMember]
        public string stock { get; set; } = string.Empty;

        [DataMember]
        public string[] modelosvehiculos { get; set; } = Array.Empty<string>();
    }
}
