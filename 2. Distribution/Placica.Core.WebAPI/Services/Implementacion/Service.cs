using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Placica.Core.Contracts.ServiceLibrary.Contracts;
using Placica.Core.WebAPI.Services.Contracts;

namespace Placica.Core.WebAPI.Services.Implementacion
{
    public abstract class Service<TModel, TDto> : IService<TModel>
        where TModel : class
        where TDto : class
    {
        private readonly IApplicationService<TDto> _applicationService;
        private readonly IMapper _mapper;
        
        public Service(
            IApplicationService<TDto> applicationService,
            IMapper mapper
        )
        {
            _applicationService = applicationService;
            _mapper = mapper;
        }

        public async Task<TModel> Add(TModel model)
        {
            var response = await _applicationService.Add(_mapper.Map<TDto>(model));
            return _mapper.Map<TModel>(response);
        }

        public async Task<TModel> Delete(int id)
        {
            var response = await _applicationService.Delete(id);
            return _mapper.Map<TModel>(response);
        }

        public async Task<TModel> Get(int id)
        {
            var response = await _applicationService.Get(id);
            return _mapper.Map<TModel>(response);
        }

        public async Task<IEnumerable<TModel>> GetAll()
        {
            var response = await _applicationService.GetAll();
            return _mapper.Map<IEnumerable<TModel>>(response);
        }

        public async Task<TModel> Update(TModel model)
        {
            var response = await _applicationService.Update(_mapper.Map<TDto>(model));
            return _mapper.Map<TModel>(response);
        }
    }
}