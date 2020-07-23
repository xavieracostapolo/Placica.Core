using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Placica.Core.WebAPI.Helpers;
using Placica.Core.WebAPI.Models;
using Placica.Core.WebAPI.Services.Contracts;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [ModelValidation]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IService<LoginModel> _service;

        public AccountController(IService<LoginModel> service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] LoginModel model)
        {
            var data = await _service.Add(model);
            return Ok(data);
        }
    }
}