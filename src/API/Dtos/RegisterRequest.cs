using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class RegisterRequest
{
  [Required]
  public string DisplayName { get; set; } = string.Empty;
  [Required]
  public string Email { get; set; } = string.Empty;
  [Required]
  [MinLength(6)]
  public string Password { get; set; } = string.Empty;
}