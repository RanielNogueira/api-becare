using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BecareDomain.Models
{
    [Table("beHospital")]
    public class Hospital
    {
        public Hospital()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public bool? Sus { get; set; }
        public bool? Publico { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Fila { get; set; }
        public bool? Ps { get; set; }
        public string Numero { get; set; }
    }
}
