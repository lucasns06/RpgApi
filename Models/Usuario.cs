using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RpgApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; // igual colocar = "";
        public byte[]? PasswordHash { get; set; } // O "?" significa que o atributo pode ser nulo
        public byte[]? PasswordSalt { get; set; }
        public byte[]? Foto { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? DataAcesso { get; set; }
        
        [NotMapped] // DataAnnotations
        public string PasswordString { get; set; } = string.Empty;
        
        public List<Personagem> Personagens { get; set; } = new List<Personagem>();
        public string Perfil { get; set; } = string.Empty;
        public string? Email { get; set; }
    }
}