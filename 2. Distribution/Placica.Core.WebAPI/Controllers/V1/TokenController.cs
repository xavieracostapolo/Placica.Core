using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Placica.Core.WebAPI.Services.Implementacion;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/[controller]/v1")]
    [ApiController]  
    public class TokenController : ControllerBase  
    {  
        private IConfiguration _config;  
  
        public TokenController(IConfiguration config)  
        {  
            _config = config;  
        }  
  
        [HttpGet]  
        public string GetRandomToken()  
        {  
            var jwt = new JwtService(_config);  
            var token = jwt.GenerateSecurityToken("fake@email.com");  
            return token;  
        }  
    } 
}