using System.ComponentModel.DataAnnotations;

namespace icdAPI.Models;

public class icdapi
{
  [Key]
  public string? code { get; set; }
  public string? description { get; set; }
}