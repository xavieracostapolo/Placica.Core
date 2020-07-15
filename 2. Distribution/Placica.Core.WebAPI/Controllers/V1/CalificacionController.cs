using Microsoft.AspNetCore.Mvc;
using Placica.Core.WebAPI.Models;
using Placica.Core.WebAPI.Services.Contracts;
using Serilog;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class CalificacionController : BaseController<Calificacion>
    {
       public CalificacionController(
           IService<Calificacion> service,
           ILogger logger)
            : base(service, logger)
       {
       } 
    }
}