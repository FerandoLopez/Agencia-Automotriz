using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorHerramientas
    {
        HerramientaDatos _herramientaD = new HerramientaDatos();

        public void GuardarProducto(Herramienta herramienta)
        {
            try
            {
                _herramientaD.GuardarHerramienta(herramienta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message);
            }
        }

        public void ActualizarHerramienta(Herramienta herramienta)
        {
            try
            {
                _herramientaD.ActualizarHerramienta(herramienta);
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
                _herramientaD.EliminarHerramienta(herramienta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }
        public List<Herramienta> ObtenerHerramientas(string filtro)
        {
            var listaUsuarios = _herramientaD.ObtenerHerramientas(filtro);
            return listaUsuarios;
        }
    }
}

