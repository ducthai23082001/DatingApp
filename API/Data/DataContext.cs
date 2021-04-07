using System;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class DataContext : DbContext
  {
    public DataContext( DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }

    internal Task SingleOrDefaultAsync(Func<object, bool> p)
    {
      throw new NotImplementedException();
    }
  }
}