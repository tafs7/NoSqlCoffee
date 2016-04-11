using System;

namespace NoSqlCoffee.Domain.Common
{
    public abstract class RepositoryBase<T>
         where T : AggregateRoot
    {
        public T GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Save(T aggregateRoot)
        {
            //TODO: transaction management?

            throw new NotImplementedException();
        }
    }
}
