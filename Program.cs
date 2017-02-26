using System;
using System.Collections.Generic;

using DDD.Entity;
using DDD.Repository;


namespace DDD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISomeRepository repository = new SomeRepository();

            repository.SaveRecord(new SomeEntity());
            repository.SaveRecord(new SomeEntity());
            repository.SaveRecord(new SomeEntity());
            repository.SaveRecord(new SomeEntity());
            repository.SaveRecord(new SomeEntity());

            var collection = repository.SelectAllRecordsBySomething() as IList<SomeEntity>;

            Console.WriteLine(collection.Count);
        }
    }
}
