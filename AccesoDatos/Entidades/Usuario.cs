using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string  _contrasenia, _conpassword, _nombre, _apellidop, _apellidom, _fechanacimiento, _rfc;
        private int _idusuario, _id_tipo;

        public string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidop { get => _apellidop; set => _apellidop = value; }
        public string Apellidom { get => _apellidom; set => _apellidom = value; }
        public string Fechanacimiento { get => _fechanacimiento; set => _fechanacimiento = value; }
        public string Rfc { get => _rfc; set => _rfc = value; }
        public int Id_tipo { get => _id_tipo; set => _id_tipo = value; }
        public string Conpassword { get => _conpassword; set => _conpassword = value; }
        public int Idusuario { get => _idusuario; set => _idusuario = value; }
    }
}
