using System.ComponentModel.DataAnnotations;

namespace Simulare.Models
{
  public class Participant
  {
 
    public int Id { get; set; }

    public string ParticipantName { get; set; }

    public int Age { get; set; }


    public Organizator Organizator { get; set; }

    public Spectator Spectator { get; set; }

    public ICollection<Event> Events { get; set; }

  }
}
