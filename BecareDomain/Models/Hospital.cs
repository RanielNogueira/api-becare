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

        public Hospital(int id, string nome, string logradouro, string cep, string telefone, bool sus, bool publico, double latitude, double longitude, double fila, bool ps)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Logradouro = logradouro;
            Cep = cep;
            Sus = sus;
            Publico = publico;
            Longitude = longitude;
            Latitude = latitude;
            Fila = fila;
            Ps = ps;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public bool Sus { get; set; }
        [Required]
        public bool Publico { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Fila { get; set; }
        [Required]
        public bool Ps { get; set; }
    }
}
