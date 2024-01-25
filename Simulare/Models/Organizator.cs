using System.ComponentModel.DataAnnotations;

namespace Simulare.Models
{
  public class Organizator
  {
  
    public int ParticipantId { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public Participant Participant { get; set; } = null!;
  }
}
