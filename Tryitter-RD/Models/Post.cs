using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tryitter_RD.Models;
public class Post
{
  [Key]
  public int PostId { get; set; }
  public string Title { get; set; } = default!;
  public string Content { get; set; } = default!;

  [ForeignKey("UserId")]
  public int UserId { get; set; }
  public virtual User User { get; set; } = default!;
}
