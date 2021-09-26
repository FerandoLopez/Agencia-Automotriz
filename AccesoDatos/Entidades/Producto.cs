using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Producto
    {
        private int _idproducto;
        private string _codigobarras, _nombre, _descripcion, _marca;

        public int Idproducto { get => _idproducto; set => _idproducto = value; }
        public string Codigobarras { get => _codigobarras; set => _codigobarras = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Marca { get => _marca; set => _marca = value; }
    }
}
