
namespace Shared.Models.Models
{
    public class Ticket
    {
        public string UserName { get; set; } = string.Empty;
        public DateTime BookedOn { get; set; }
        public string Boarding { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
    }
}