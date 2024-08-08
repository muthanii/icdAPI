using icdAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
  options.UseNpgsql(builder.Configuration.GetConnectionString("dbConnection"))
);

var app = builder.Build();

app.MapGet("api/all", (AppDbContext db) =>
{
  var description = db.icdapi.ToList();
  return Results.Ok(description);
});

app.Run();