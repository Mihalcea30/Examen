using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Simulare.Models;

namespace Simulare.Data
{
  public class SimulareContext :DbContext
  {
    
    public SimulareContext(DbContextOptions options) : base(options) { }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Student> Students { get; set; }
    
  }
}
