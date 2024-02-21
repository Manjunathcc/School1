using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Models;

namespace SchoolManagement.Infrastructure.DbContext
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Student> Students { get; set; }    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
