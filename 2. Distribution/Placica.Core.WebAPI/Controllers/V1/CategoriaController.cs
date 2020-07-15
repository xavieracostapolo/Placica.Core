using Microsoft.AspNetCore.Mvc;
using Placica.Core.WebAPI.Models;
using Placica.Core.WebAPI.Services.Contracts;
using Serilog;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class CategoriaController : BaseController<Categoria>
    {
       public CategoriaController(
           IService<Categoria> service,
           ILogger logger)
            : base(service, logger)
       {
       } 
    }
}