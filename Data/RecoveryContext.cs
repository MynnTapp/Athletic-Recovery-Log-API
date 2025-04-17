using AthleticRecoveryAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AthleticRecoveryAPI.Data
{
    public class RecoveryContext:  IdentityDbContext<User>
    {
        public RecoveryContext(DbContextOptions<RecoveryContext> options): base(options)
        {

        }

        public DbSet<RecoveryLog> RecoveryLogs {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RecoveryLog>().HasOne(r => r.User).WithMany(u => u.RecoveryLogs).HasForeignKey(r => r.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}