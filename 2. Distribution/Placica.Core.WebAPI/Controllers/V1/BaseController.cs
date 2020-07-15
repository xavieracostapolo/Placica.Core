using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Placica.Core.WebAPI.Services.Contracts;
using Serilog;

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
            var data = await _service.GetAll();
            throw new Exception("Exception while fetching all the students from the storage.");

            // return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var data = await _service.Get(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TModel model)
        {
            var data = await _service.Add(model);
            return Ok(data);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, [FromBody] TModel model)
        {
            if (((dynamic)model).Id == id)
            {
                var data = await _service.Update(model);
                return Ok(data);
            }

            return BadRequest("Id y datos a modificar no corresponden");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOwner(long id)
        {
            var data = _service.Delete(id);
            return Ok(data);
        }
    }
}