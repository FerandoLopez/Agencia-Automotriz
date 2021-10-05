using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorPerfiles
    {
        Conexion c = new Conexion("localhost", "root", "12345", "agenciaautomotriz", 3306);

        public string Guardar(Perfiles perfil)
        {
            return c.Comando(string.Format("insert into perfiles values(null,'{0}')",
                 perfil._Nombre));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("select * from perfiles where nombre like '%{0}%'", dato), "perfiles").Tables["perfiles"];
            tabla.AutoResizeColumns();
        }

        public string Editar(Perfiles perfil)
        {
            return c.Comando(string.Format("update perfiles set nombre='{0}' where idusuario='{1}'", perfil._Nombre,perfil._Id));
        }

        public string Borrar(Perfiles perfil)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + perfil._Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("delete from perfiles where id = {0}", perfil._Id));
            }
            return r;
        }
    }
}
