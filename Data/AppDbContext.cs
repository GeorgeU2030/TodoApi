// Data/AppDbContext.cs

using CSharpCornerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpCornerApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<CSharpCornerArticle> Articles { get; set; }
    }
}