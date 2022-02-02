using Microsoft.EntityFrameworkCore;
using SPAWebSMS.Application.Interfaces;
using SPAWebSMS.Domain;
using SPAWebSMS.Persistence.EntityTypeConfigurations;

namespace SPAWebSMS.Persistence
{
    public class SPAWebSMSDbContext : DbContext, ISPAWebSMSDbContext
    {
        public DbSet<Message> Messages { get; set; }

        public SPAWebSMSDbContext(DbContextOptions<SPAWebSMSDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MessageConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
