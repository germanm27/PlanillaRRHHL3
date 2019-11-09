using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contrasena)
        {
            if (usuario == "admin1" && contrasena == "12345")
            {
                return true;
            }
            else
            {
                if (usuario == "supervisor1" && contrasena == "1234")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
