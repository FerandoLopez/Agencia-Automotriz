using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatosPermisos
    {
        public int _IdPermiso { get; set; }
        public string _NombrePermiso { get; set; }

        public DatosPermisos(int idpermiso, string nombrepermiso)
        {
            _IdPermiso = idpermiso;
            _NombrePermiso = nombrepermiso;
        }
        public DatosPermisos()
        {

        }
    }
}
