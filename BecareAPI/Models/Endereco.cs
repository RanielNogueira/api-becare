using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BecareAPI.Models
{
    public class Endereco
    {
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public double Latitude { get; set; }
    }
}
