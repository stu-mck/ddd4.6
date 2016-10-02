using System;
using System.Collections.Generic;
using TechLibrary.Interfaces;

namespace TechLibrary.Domain.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T: IEntity
    {

        protected readonly Dictionary<Guid, T> _mockStore = new Dictionary<Guid, T>();

        public T GetByID(Guid id)
        {
            return _mockStore.ContainsKey(id) ? _mockStore[id] : default(T);
        }

        public void Save(T entity)
        {
            if (!_mockStore.ContainsKey(entity.ID))
                _mockStore.Add(entity.ID, entity);
            else
                _mockStore[entity.ID] = entity;

        }
    }
}
