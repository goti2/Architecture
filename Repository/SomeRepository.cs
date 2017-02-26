using System.Collections.Generic;

using DDD.Entity;
using DDD.Storage;


namespace DDD.Repository
{
    public class SomeRepository : ISomeRepository 
    {
        protected ListDataStorage<SomeEntity> storage;

        public SomeRepository()
        {
            this.storage = new ListDataStorage<SomeEntity>();
        }

        public void SaveRecord(SomeEntity entity)
        {
            this.storage.Insert(entity);
        }

        public IEnumerable<SomeEntity> SelectAllRecordsBySomething()
        {
            return this.storage.Context.FindAll(entity => true);
        }
    }
}