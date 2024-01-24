using System.ComponentModel.DataAnnotations;

namespace Simulare.Models
{
  public class Student
  {
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public string University { get; set; }

  }
}
