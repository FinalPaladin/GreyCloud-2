namespace GreyCloud.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private GreyCloudDbContext dbContext;

        public GreyCloudDbContext Init()
        {
            return dbContext ?? (dbContext = new GreyCloudDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}