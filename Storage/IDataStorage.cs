namespace DDD.Storage
{
    public interface IDataStorage<TEntity>
    {
        void InitializeContext();

        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}