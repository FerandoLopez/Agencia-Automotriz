using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorProductos
    {
        ProductoDatos _productosD = new ProductoDatos();

        public void GuardarProducto(Producto producto)
        {
            try
            {
                _productosD.GuardarProducto(producto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message);
            }
        }

        public void ActualizarProducto(Producto producto)
        {
            try
            {
                _productosD.ActualizarProducto(producto);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualización" + ex.Message);
            }
        }
        public void EliminarProducto(string producto)
        {
            try
            {
                _productosD.EliminarProducto(producto);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }
        public List<Producto> ObtenerProducto(string filtro)
        {
            var listaUsuarios = _productosD.ObtenerProducto(filtro);
            return listaUsuarios;
        }
    }
}
