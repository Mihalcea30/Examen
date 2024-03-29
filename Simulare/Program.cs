using Microsoft.EntityFrameworkCore;
using Simulare.Data;
using System.Text.Json.Serialization;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SimulareContext>(options =>
                options.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Sim;Integrated Security=True"));

builder.Services.AddControllersWithViews()
    .AddJsonOptions(options =>
    {
      options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
      options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseCors(options => options.WithOrigins("http://localhost:4200")
.AllowAnyMethod()
.AllowAnyHeader());
app.UseAuthorization();

app.MapControllers();


app.Run();
