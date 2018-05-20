namespace GreyCloud.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}