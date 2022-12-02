using LittleRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LittleRestApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<SomeData> SomeDatas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SomeData>().HasData(
                    new SomeData { Data = "SomeData1" },
                    new SomeData { Data = "SomeData2" },
                    new SomeData { Data = "SomeData3" },
                    new SomeData { Data = "SomeData4" },
                    new SomeData { Data = "SomeData5" },
                    new SomeData { Data = "SomeData6" },
                    new SomeData { Data = "SomeData7" },
                    new SomeData { Data = "SomeData8" },
                    new SomeData { Data = "SomeData9" },
                    new SomeData { Data = "SomeData10" },
                    new SomeData { Data = "SomeData11" },
                    new SomeData { Data = "SomeData12" },
                    new SomeData { Data = "SomeData13" },
                    new SomeData { Data = "SomeData14" },
                    new SomeData { Data = "SomeData15" }
            );
        }

    }
}
