using System.ComponentModel.DataAnnotations;

namespace WebService.Models
{
    public class Client
    {
        public int? Id { get; set; } //pk
        [Required]
        public string IpAddress { get; set; }
        [Required]
        public string Port { get; set; }
    }
}
