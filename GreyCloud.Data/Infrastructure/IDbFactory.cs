using System;

namespace GreyCloud.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        GreyCloudDbContext Init();
    }
}