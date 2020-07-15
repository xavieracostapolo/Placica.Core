using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Placica.Core.Library.Contracts.DomainServices;
using Placica.Core.Library.Contracts.Repository;
using Placica.Core.Library.Entities;

namespace Placica.Core.Library.DomainServices
{
    public abstract class DomainService<TEntity> : IDomainService<TEntity>
        where TEntity : class, IEntity
    {
        private readonly IRepository<TEntity> _repository;

        public DomainService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            return await _repository.Add(entity);
        }

        public async Task<TEntity> Delete(long id)
        {
            return await _repository.Delete(id);
        }

        public async Task<TEntity> Get(long id)
        {
            return await _repository.Get(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public IQueryable<TEntity> GetAllQueryable()
        {
            return _repository.GetAllQueryable();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            return await _repository.Update(entity);
        }
    }
}