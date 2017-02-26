using System;
using System.Collections.Generic;


namespace DDD.Storage
{
    public class ListDataStorage<TEntity> : IDataStorage<TEntity>
    {
        public List<TEntity> Context { get; private set; }

        public ListDataStorage()
        {
            this.Context = new List<TEntity>();
        }

        public void InitializeContext()
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            this.Context.Remove(entity);
        }

        public void Insert(TEntity entity)
        {
            this.Context.Add(entity);
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}