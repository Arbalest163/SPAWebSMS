namespace SPAWebSMS.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(SPAWebSMSDbContext dbContext)
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }
    }
}
