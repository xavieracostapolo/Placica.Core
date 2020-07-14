using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Placica.Core.Contracts.ServiceLibrary.Contracts;
using Placica.Core.Library.Contracts.DomainServices;
using Placica.Core.Library.Entities;

namespace Placica.Core.Impl.ServiceLibrary.ApplicationServices
{
    public abstract class ApplicationService<TDto, TEntity> : IApplicationService<TDto>
        where TDto : class
        where TEntity : class, IEntity
    {
        private readonly IDomainService<TEntity> _domainService;
        private readonly IMapper _mapper;

        public ApplicationService(
            IDomainService<TEntity> domainService,
            IMapper mapper)
        {
            _domainService = domainService;
            _mapper = mapper;
        }

        public async Task<TDto> Add(TDto dto)
        {
            var response = await _domainService.Add(_mapper.Map<TEntity>(dto));
            return _mapper.Map<TDto>(response);
        }

        public async Task<TDto> Delete(int id)
        {
            var response = await _domainService.Delete(id);
            return _mapper.Map<TDto>(response);
        }

        public async Task<TDto> Get(int id)
        {
            var response = await _domainService.Get(id);
            return _mapper.Map<TDto>(response);
        }

        public async Task<IEnumerable<TDto>> GetAll()
        {
            var response = await _domainService.GetAll();
            return _mapper.Map<IEnumerable<TDto>>(response);
        }

        public async Task<TDto> Update(TDto dto)
        {
            var response = await _domainService.Update(_mapper.Map<TEntity>(dto));
            return _mapper.Map<TDto>(response);
        }
    }
}