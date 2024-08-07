using icdAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace icdAPI.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {

  }
  public DbSet<icdapi> icdapi { get; set; }
}