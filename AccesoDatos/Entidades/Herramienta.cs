using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Herramienta
    {
        private int _idherramienta;
        private string _codigoherramienta, _nombre, _medida, _marca, _descripcion;

        public int Idherramienta { get => _idherramienta; set => _idherramienta = value; }
        public string Codigoherramienta { get => _codigoherramienta; set => _codigoherramienta = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Medida { get => _medida; set => _medida = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
