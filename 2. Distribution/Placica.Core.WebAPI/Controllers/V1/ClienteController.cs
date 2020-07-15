using Microsoft.AspNetCore.Mvc;
using Placica.Core.WebAPI.Models;
using Placica.Core.WebAPI.Services.Contracts;
using Serilog;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class ClienteController : BaseController<Cliente>
    {
       public ClienteController(
           IService<Cliente> service,
           ILogger logger)
            : base(service, logger)
       {
       } 
    }
}