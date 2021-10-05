using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perfiles
    {
        public Perfiles(int id, string nombre)
        {
            _Id = id;
            _Nombre = nombre;
        }

        public int _Id { get; set; }
        public string _Nombre { get; set; }
    }
}
