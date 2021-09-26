using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entidades;

namespace AccesoDatos
{
   public class LoginDatos
    {
        Conexion _conexion;
        public LoginDatos()
        {
            try
            {
                _conexion = new Conexion("localhost", "root", "12345", "agenciaautomotriz",3306);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la conexion" + ex.Message);
            }
        }
        public int ObtenerLogins(string user, string password)
        {
            string consulta = string.Format("select count(*) from usuarios where nombre = '{0}' and Contrasenia = '{1}';", user, password);
            int Contar = int.Parse(_conexion.ConsultaRetorno(consulta));
            return Contar;
        }

    }
    }
