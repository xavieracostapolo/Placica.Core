using Model = Placica.Core.WebAPI.Models;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;
using AutoMapper;
using Placica.Core.Contracts.ServiceLibrary.Contracts;
using System.Threading.Tasks;
using Placica.Core.WebAPI.Services.Contracts;

namespace Placica.Core.WebAPI.Services.Implementacion
{
    public class UsuarioService : Service<Model.LoginModel, Dto.Usuario>, IUsuarioService
    {
        private readonly IUsuarioApplicationService _usuarioApplicationService;
        private readonly IMapper _mapper;

        public UsuarioService(
            IApplicationService<Dto.Usuario> applicationService,
            IMapper mapper,
            IUsuarioApplicationService usuarioApplicationService)
            : base(applicationService, mapper)
        {
            _usuarioApplicationService = usuarioApplicationService;
            _mapper = mapper;
        }

        // We can add new methods specific here in the future
        public async Task<Model.LoginModel> AddLoginUsuario(Model.LoginModel model)
        {
            var response = await _usuarioApplicationService.AddLoginUsuario(_mapper.Map<Dto.Usuario>(model));
            return _mapper.Map<Model.LoginModel>(response);
        }
    }
}