using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmanuelBarrazaAppV1.Models;
using EmanuelBarrazaAppV1.Repositories;

namespace EmanuelBarrazaAppV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {


        [HttpGet("{idUsuario}")]
        public List<Producto> GetSaleProduct( long idUsuario)
        {
            // ManejadorProducto.ObtenerProductoVendido(idUsuario);
            return ManejadorProducto.ObtenerProductos(idUsuario);
        }


        [HttpPost]
        public void InsertProduct(Producto producto)
        {
            ManejadorProducto.InsertarProducto(producto);
        }

        [HttpPut]
        public void UpDateProduct(Producto producto)
        {

            ManejadorProducto.ModificarProducto(producto);
        }

        [HttpDelete("{idProducto}")]
        public void DeleteProduct(int idProducto)
        {
            ManejadorProducto.EliminarProducto(idProducto);
        }


    }
}
