using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Placica.Core.WebAPI.Models;
using Placica.Core.WebAPI.Services.Contracts;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class PedidoController : BaseController<Pedido>
    {
       public PedidoController(
           IService<Pedido> service,
           ILogger<PedidoController> logger)
            : base(service, logger)
       {
       } 
    }
}