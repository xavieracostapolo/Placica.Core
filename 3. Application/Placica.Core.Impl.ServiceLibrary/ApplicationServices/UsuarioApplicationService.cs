using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Placica.Core.Contracts.ServiceLibrary.Contracts;
using Placica.Core.Contracts.ServiceLibrary.Dto;
using Placica.Core.Library.Contracts.DomainServices;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;
using Entity = Placica.Core.Library.Entities;

namespace Placica.Core.Impl.ServiceLibrary.ApplicationServices
{
    public class UsuarioApplicationService : ApplicationService<Dto.Usuario, Entity.Usuario>, IUsuarioApplicationService
    {
        private readonly IDomainService<Entity.Usuario> _domainService;
        private readonly IMapper _mapper;
        
        public UsuarioApplicationService(
            IDomainService<Entity.Usuario> domainService,
            IMapper mapper)
            : base(domainService, mapper)
        {
            _domainService = domainService;
            _mapper = mapper;
        }

        // We can add new methods specific here in the future
        public async Task<Dto.Usuario> GetByUserId(string id)
        {
            var response = _domainService.GetAllQueryable()
            .Where(u => u.UserId == id)
            .FirstOrDefault();

            return await Task.FromResult<Dto.Usuario>(_mapper.Map<Dto.Usuario>(response));
        }

        public async Task<Dto.Usuario> AddLoginUsuario(Dto.Usuario user)
        {
            var currentUser = _domainService.GetAllQueryable()
            .Where(u => u.UserId == user.UserId)
            .FirstOrDefault();

            if (currentUser != null) {
                return _mapper.Map<Dto.Usuario>(currentUser);
            }

            var response = await _domainService.Add(_mapper.Map<Entity.Usuario>(user));
            return _mapper.Map<Dto.Usuario>(response);
        }

    }
}