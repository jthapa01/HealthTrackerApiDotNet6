using JeevanNotebook.Entities.DbSet;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JeevanNotebook.DataService.Data;
public class AppDbContext : IdentityDbContext
{
    public virtual DbSet<User> Users { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

}