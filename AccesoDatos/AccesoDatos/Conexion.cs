using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class Conexion
    {
        private MySqlConnection _conn;
        string valor = "";

        public Conexion(string server, string user, string password, string database, uint port)
        {
            MySqlConnectionStringBuilder cadenaConexion = new MySqlConnectionStringBuilder();

            cadenaConexion.Server = server;
            cadenaConexion.UserID = user;
            cadenaConexion.Password = password;
            cadenaConexion.Database = database;
            cadenaConexion.Port = port;

            _conn = new MySqlConnection(cadenaConexion.ToString());
        }
        public void EjecutarConsulta(string consulta)
        {
            _conn.Open();
            var command = new MySqlCommand(consulta, _conn);
            command.ExecuteNonQuery();

            _conn.Close();
        }
        public string EjecutarConsultaRetorno(string consulta)
        {
            _conn.Open();

            var command = new MySqlCommand(consulta, _conn);
            command.ExecuteNonQuery();
            valor = Convert.ToString(command.ExecuteScalar());

            _conn.Close();
            return valor;
        }

        public DataSet ObtenerDatos(string consulta, string tabla)
        {
            var ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, _conn);
            da.Fill(ds, tabla);
            return ds;
        }
    }
}
