using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entidades;

namespace AccesoDatos
{
    public class Conexion
    {
        MySqlConnection _conn;
        string valor = "";
        string permiso = "";
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

        public string Permiso(string consulta)
        {
            try
            {
                _conn.Open();
                var command = new MySqlCommand(consulta, _conn);
                command.ExecuteNonQuery();
                permiso = Convert.ToString(command.ExecuteScalar());
                _conn.Close();
                return permiso;


                /*   MySqlCommand c = new MySqlCommand(q, _conn);
                   _conn.Open();
                   c.ExecuteNonQuery();
                   _conn.Close();
                   var permiso = string.Format("select id_tipo from usuarios where Nombre = '{0}'");
                   return permiso;*/
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

        public List<DatosPermisos> LlenarCombo(string consulta)
        {
            List<DatosPermisos> lista = new List<DatosPermisos>();

            try
            {
                _conn.Open();
                var command = new MySqlCommand(consulta, _conn);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DatosPermisos dc = new DatosPermisos();
                        dc._IdPermiso = int.Parse(reader["id"].ToString());
                        dc._NombrePermiso = reader["nombre"].ToString();
                        lista.Add(dc);
                    }
                }
                _conn.Close();
                return lista;
            }
            catch (Exception)
            {
                _conn.Close();
                return lista;
            }
        }
    }
}
