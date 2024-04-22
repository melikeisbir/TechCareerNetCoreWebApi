using Microsoft.EntityFrameworkCore;
using TechCareerNetCoreWebApi.Models;

namespace TechCareerNetCoreWebApi.Data
{
    //veri tabanındaki tüm tablolara erişebilmeyi ve onlar üzerinde işlem yapabilmeyi sağlayan genel bir class
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Movie> Movie { get; set; }

    }
}
