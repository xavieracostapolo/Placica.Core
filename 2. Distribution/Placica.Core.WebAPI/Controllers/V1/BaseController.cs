using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Placica.Core.WebAPI.Services.Contracts;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TModel> : Controller
        where TModel : class
    {
        private readonly IService<TModel> _service;
        
        public BaseController(IService<TModel> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<TModel>> Get()
        {
            return await _service.GetAll();
        }
    }
}