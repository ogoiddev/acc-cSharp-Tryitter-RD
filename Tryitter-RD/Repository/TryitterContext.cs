
using Microsoft.EntityFrameworkCore;
using Tryitter_RD.Models;

namespace Tryitter_RD.Repository;

public class TryitterContext : DbContext
{
  public DbSet<Post> Posts { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    // throw new NotImplementedException();

    optionsBuilder.UseSqlServer(
      @"server=127.0.0.1;
        database=library;
        user=root;
        password=Password12!;
        trusted_connection=true;"
    );
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    // throw new NotImplementedException();

    modelBuilder.Entity<Post>().HasKey(data => data.PostId);

    modelBuilder.Entity<User>().HasKey(data => data.UserId);

    modelBuilder.Entity<Post>()
      .HasOne(data => data.User)
      .WithMany(data => data.Posts)
      .HasForeignKey(data => data.UserId);
  }
}
