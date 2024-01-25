using System.ComponentModel.DataAnnotations;

namespace Simulare.Models
{
  public class Event
  {
    
    public int Id { get; set; } 
    public string EventName { get; set; }

    public string Place {  get; set; }


    public ICollection<Participant> Participants { get; set; }


  }
}
