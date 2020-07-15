using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Placica.Core.WebAPI.Models;
using Placica.Core.WebAPI.Services.Contracts;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class ProductoController : BaseController<Producto>
    {
       public ProductoController(
           IService<Producto> service,
           ILogger<ProductoController> logger)
            : base(service, logger)
       {
       } 
    }
}