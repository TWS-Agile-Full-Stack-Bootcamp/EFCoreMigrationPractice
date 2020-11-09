using System;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMigrationPractice.Models
{
    public class CourtDbContext : DbContext
    {
        public CourtDbContext(DbContextOptions<CourtDbContext> options)
            : base(options)
        {
        }

        public DbSet<Prosecutor> Prosecutor { get; set; }
    }
}
