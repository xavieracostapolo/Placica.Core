using Microsoft.AspNetCore.Mvc;
using Placica.Core.WebAPI.Models;
using Placica.Core.WebAPI.Services.Contracts;

namespace Placica.Core.WebAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : BaseController<Producto>
    {
       public ProductoController(IService<Producto> service)
            : base(service)
       {
       } 
    }
}