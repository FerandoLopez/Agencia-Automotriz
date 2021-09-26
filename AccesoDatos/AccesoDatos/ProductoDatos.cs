using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class ProductoDatos
    {
        Conexion _conexion;
        public ProductoDatos()
        {
            try
            {
                _conexion = new Conexion("localhost", "root", "12345", "agenciaautomotriz", 3306);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la conexion" + ex.Message);
            }
        }
        public void GuardarProducto(Producto producto)
        {
            try
            {
                string consulta = string.Format("insert into producto values(null,'{0}','{1}','{2}','{3}')", producto.Codigobarras, producto.Nombre, producto.Descripcion, producto.Marca);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void ActualizarProducto(Producto producto)
        {
            try
            {
                string consulta = string.Format("update producto set codigobarras = '{1}', nombre = '{2}', descripcion = '{3}', marca = '{4}' where idproducto = '{0}'", producto.Idproducto, producto.Codigobarras, producto.Nombre, producto.Descripcion, producto.Marca);
                _conexion.EjecutarConsulta(consulta);
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
                string consulta = string.Format("delete from producto where idproducto = '{0}'", producto);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }
        public List<Producto> ObtenerProducto(string filtro)
        {
            var listaProducto = new List<Producto>();
            var ds = new DataSet();
            string consulta = string.Format("select * from producto where nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "producto");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var producto = new Producto
                {
                    Idproducto = int.Parse((string)row["Id"]),
                    Codigobarras = row["CodigoBarras"].ToString(),
                    Nombre = row["Nombre"].ToString(),
                    Descripcion=row["Descripcion"].ToString(),
                    Marca=row["Marca"].ToString()

                };

                listaProducto.Add(producto);
            }
            return listaProducto;
        }
    }
}
