using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NuGet.Protocol.Plugins;
using Simulare.Models;

namespace Simulare.Data
{
  public class SimulareContext :DbContext
  {
    
    public SimulareContext(DbContextOptions options) : base(options) { }

    
    public DbSet<Event> Events { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<Organizator> Organizatori { get; set; }

    public DbSet<Spectator> Spectators { get; set;}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


      modelBuilder.Entity<Organizator>()
       .HasKey(c => c.ParticipantId);
      modelBuilder.Entity<Spectator>()
        .HasKey(p => p.ParticipantId);
      modelBuilder.Entity<Participant>()
        .HasKey(s => s.Id);
      modelBuilder.Entity<Event>()
        .HasKey(a => a.Id);



      modelBuilder.Entity<Participant>()
               .HasMany(o => o.Events)
               .WithMany(p => p.Participants)
               .UsingEntity(j => j.ToTable("Event_Participant"));

      modelBuilder.Entity<Participant>()
          .HasOne(e => e.Organizator)
      .WithOne(e => e.Participant)
          .HasForeignKey<Organizator>(e => e.ParticipantId)
          .IsRequired();


      modelBuilder.Entity<Participant>()
          .HasOne(e => e.Spectator)
      .WithOne(e => e.Participant)
          .HasForeignKey<Spectator>(e => e.ParticipantId)
          .IsRequired();














    }


  }
}
