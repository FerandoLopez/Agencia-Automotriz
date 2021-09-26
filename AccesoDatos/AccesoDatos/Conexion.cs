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
        MySqlConnection _conn;
        string valor = "";
        public Conexion(string server, string user, string password, string based, uint port)
        {
            _conn = new MySqlConnection(string.Format("server={0}; user={1}; password={2}; database = {3}; port = {4}", server, user, password,
                based, port));
        }
        public string Comando(string q)
        {
            try
            {
                MySqlCommand c = new MySqlCommand(q, _conn);
                _conn.Open();
                c.ExecuteNonQuery();
                _conn.Close();
                return "Correcto";
            }
            catch (Exception ex)
            {
                _conn.Close();

                return ex.Message;
            }
        }
        public DataSet Mostrar(string q, string tabla)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(q, _conn);
                _conn.Open();
                da.Fill(ds, tabla);
                _conn.Close();
                return ds;
            }
            catch (Exception)
            {
                _conn.Close();
                return ds;
            }
        }

        public string ConsultaRetorno(string consulta)
        {
            _conn.Open();
            var command = new MySqlCommand(consulta, _conn);
            command.ExecuteNonQuery();
            valor = Convert.ToString(command.ExecuteScalar());
            _conn.Close();
            return valor;
        }
    }
}
