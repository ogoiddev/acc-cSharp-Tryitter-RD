using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tryitter_RD.Models;
public class User
{
  [Key]
  public int UserId { get; set; }
  public string Name { get; set; } = default!;
  private string Password { get; set; } = default!;
  public string Email { get; set; } = default!;
  public string Status { get; set; } = default!;

  [InverseProperty("User")]
  public virtual ICollection<Post> Posts { get; } = default!;
}
