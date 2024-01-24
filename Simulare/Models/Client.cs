using System.ComponentModel.DataAnnotations;

namespace Simulare.Models
{
  public class Client
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Adress { get; set; } = " ";
  }
}
