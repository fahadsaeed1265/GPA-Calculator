using Microsoft.EntityFrameworkCore;
using UE_GPA.Models;

namespace UE_GPA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<StudentMark> StudentMarks { get; set; }
    }
}
