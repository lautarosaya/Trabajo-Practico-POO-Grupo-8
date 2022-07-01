using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows;
namespace Controladora
{
    public class usuarios
    {
        public int identificador (string usuarios, string contrasena) 
        {
            if(usuarios == "admin" && contrasena == "Osonegro123")
            {
                return 1;
            }
            return -1;
        }  

    }
}
