namespace Restaurante.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>()
            where T : class;

        void SaveChanges();

        void SetAutoDetectChanges(bool enabled);
    }
}
