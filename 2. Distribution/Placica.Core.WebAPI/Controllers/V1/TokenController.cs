using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Placica.Core.WebAPI.Services.Implementacion;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]  
    public class TokenController : ControllerBase  
    {  
        private IConfiguration _config;  
  
        public TokenController(IConfiguration config)  
        {  
            _config = config;  
        }  
  
        [HttpGet]  
        public IActionResult GetRandomToken()  
        {  
            var jwt = new JwtService(_config);  
            var token = jwt.GenerateSecurityToken("sitivo5@hotmail.com");  
            return Ok(new { Token = token });
        }  
    } 
}