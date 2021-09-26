using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class HerramientaDatos
    {
        Conexion _conexion;
        public HerramientaDatos()
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
        public void GuardarHerramienta(Herramienta herramienta)
        {
            try
            {
                string consulta = string.Format("insert into herramienta values(null,'{0}','{1}','{2}','{3}','{4}')", herramienta.Codigoherramienta, herramienta.Nombre,herramienta.Medida,herramienta.Marca,herramienta.Descripcion);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void ActualizarHerramienta(Herramienta herramienta)
        {
            try
            {
                string consulta = string.Format("update herramienta set codigoherramienta = '{1}', nombre = '{2}', medida = '{3}', marca = '{4}' , descripcion ='{5}'where idherramienta = '{0}'", herramienta.Idherramienta, herramienta.Codigoherramienta, herramienta.Nombre, herramienta.Medida, herramienta.Marca, herramienta.Descripcion);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la actualización" + ex.Message);
            }
        }
        public void EliminarHerramienta(string herramienta)
        {
            try
            {
                string consulta = string.Format("delete from herramienta where idherramienta = '{0}'", herramienta);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }
        public List<Herramienta> ObtenerHerramientas(string filtro)
        {
            var listaHerramienta = new List<Herramienta>();
            var ds = new DataSet();
            string consulta = string.Format("select * from herramienta where nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "herramienta");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var herramienta = new Herramienta
                {
                    Idherramienta= int.Parse((string)row["Id"]),
                    Codigoherramienta = row["CodigoHerramienta"].ToString(),
                    Nombre=row["Nombre"].ToString(),
                    Medida =row["Medida"].ToString(),
                    Marca =row["Marca"].ToString(),
                    Descripcion =row["Descripcion"].ToString(),
                };

                listaHerramienta.Add(herramienta);
            }
            return listaHerramienta;
        }
    }
}

