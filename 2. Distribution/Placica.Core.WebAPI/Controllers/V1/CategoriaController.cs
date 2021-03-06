using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Placica.Core.WebAPI.Models;
using Placica.Core.WebAPI.Services.Contracts;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriaController : BaseController<Categoria>
    {
       public CategoriaController(
           IService<Categoria> service,
           ILogger<CategoriaController> logger)
            : base(service, logger)
       {
       } 
    }
}