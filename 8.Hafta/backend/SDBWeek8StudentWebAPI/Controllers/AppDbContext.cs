namespace SDBWeek8StudentWebAPI.Controllers;
using Microsoft.EntityFrameworkCore;
using SDBWeek8StudentWebAPI.Entities;

public class AppDbContext : DbContext
{
    public DbSet<StudentEntity> Students { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
