using Microsoft.EntityFrameworkCore;
using School_Adm.Models;

namespace School_Adm.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Student> Students { get; set; } = null!;

}
