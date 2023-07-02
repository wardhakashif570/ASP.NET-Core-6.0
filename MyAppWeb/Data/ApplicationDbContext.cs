namespace MyAppWeb.Data;
using Microsoft.EntityFrameworkCore;
using MyAppWeb.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
}
