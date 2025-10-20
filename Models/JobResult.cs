using System.ComponentModel.DataAnnotations;

namespace WebService.Models
{
    public class JobResult
    {
        public int? Id { get; set; } //pk
        public int ClientId { get; set; }
        public string Result { get; set; }
    }
}
