using Microsoft.AspNetCore.Mvc;
using Tryitter_RD.Models;
using Tryitter_RD.Repository;

namespace Tryitter_RD.Controllers;

[ApiController]
[Route("api")]
public class TryitterController : Controller
{
  private readonly TrytterRepository _repository;
  public TryitterController(TrytterRepository repository)
  {
    _repository = repository;
  }

  [HttpPost("Post")]
  public void CreatePost(Post post)
  {
    _repository.Add(post);
  }

  [HttpDelete("Post/{id}")]
  public void DeletePost(int id)
  {    
    var post = _repository.Get(id);
    
    _repository.Delete(post);
  }

  [HttpGet("Post/{id}")]
  public Post? GetPost(int id)
  {    
    return _repository.Get(id);
  }

  [HttpPut("Post")]
  public void UpdatePost(Post post)
  {
    _repository.Update(post);
  }
}
