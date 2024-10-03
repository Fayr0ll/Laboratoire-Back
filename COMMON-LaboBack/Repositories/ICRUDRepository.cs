using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace COMMON_LaboBack.Repositories
{
    public interface ICRUDRepository<TEntity, TId> where TEntity : IEntity
    {
        public IEnumerable<TEntity> Get();
        public TEntity Get(TId id);
        public bool Insert(TEntity entity);
        public void Update(TId id, TEntity entity);
        public void Delete(TId id);
    }
}
