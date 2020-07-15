using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Placica.Core.WebAPI.Services.Contracts;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TModel> : Controller
        where TModel : class
    {
        private readonly IService<TModel> _service;
        private readonly ILogger _logger;

        public BaseController(
            IService<TModel> service,
            ILogger logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("Inicio del metodo obtener.");
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TModel model)
        {
            _logger.LogInformation("Inicio del metodo obtener.");
            var data = await _service.Add(model);
            return Ok(data);
        }
    }
}