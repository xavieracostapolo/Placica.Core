using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Placica.Core.WebAPI.Models;
using Placica.Core.WebAPI.Services.Contracts;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CalificacionController : BaseController<Calificacion>
    {
       public CalificacionController(
           IService<Calificacion> service,
           ILogger<CalificacionController> logger)
            : base(service, logger)
       {
       } 
    }
}