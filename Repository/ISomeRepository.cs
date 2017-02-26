using System.Collections.Generic;

using DDD.Entity;


namespace DDD.Repository
{
    public interface ISomeRepository
    {
        void SaveRecord(SomeEntity entity);
        IEnumerable<SomeEntity> SelectAllRecordsBySomething();
    }
}