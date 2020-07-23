using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Placica.Core.WebAPI.Models;
using Placica.Core.WebAPI.Services.Contracts;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PedidoDetalleController : BaseController<PedidoDetalle>
    {
       public PedidoDetalleController(
           IService<PedidoDetalle> service,
           ILogger<PedidoDetalleController> logger)
            : base(service, logger)
       {
       } 
    }
}