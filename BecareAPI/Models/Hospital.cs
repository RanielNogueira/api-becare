using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BecareAPI.Models
{
    public class Hospital
    {
        public Hospital(int id, string nome, string logradouro, string cep, string telefone, bool sus, bool publico, double latitude, double longitude, string fila)
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
        public bool Sus { get; set; }
        public bool Publico { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public string Fila { get; set; }
    }
}
