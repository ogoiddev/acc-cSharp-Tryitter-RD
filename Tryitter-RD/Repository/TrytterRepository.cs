// using Microsoft.EntityFrameworkCore;
using Tryitter_RD.Models;

namespace Tryitter_RD.Repository;

public class TrytterRepository
{
  protected readonly TryitterContext _context;


  public TrytterRepository(TryitterContext context)
  {
    _context = context;
  }

  public virtual void Add(Post entity)
  {
    // throw new NotImplementedException();

    _context.Add(entity);
    _context.SaveChanges();
  }

  public virtual void Delete(Post entity)
  {
    // throw new NotImplementedException();

    var post = _context.Posts.Where(data => data.PostId == entity.PostId);

    _context.Remove(entity.User);
    _context.Remove(entity);
    _context.SaveChanges();
  }

  public virtual void Update(Post entity)
  {
    // throw new NotImplementedException();

    _context.Update(entity);
    _context.SaveChanges();
  }

  public virtual Post? Get(int id)
  {
    // throw new NotImplementedException();

    return _context.Posts.Where(data => data.PostId == id).FirstOrDefault();
  }
  public virtual List<Post> GetAll()
  {
    // throw new NotImplementedException();

    return _context.Posts.ToList();
  }
}
