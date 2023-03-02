using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmanuelBarrazaAppV1.Models;
using EmanuelBarrazaAppV1.Repositories;

namespace EmanuelBarrazaAppV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {


        [HttpGet("{idUsuario}")]
        public List<Producto> GetSaleProductByUserId(long idUsuario)
        {
            
            return ManejadorProductoVendido.ObtenerProductoVendido(idUsuario);
        }

    }

}

