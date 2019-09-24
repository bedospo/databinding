using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class empleado
    {
        public string Nombre { get; set;}
        public string Titulo { get; set;}

        public static empleado GetEmpleado()
        {
            var emp = new empleado()
            {
                Nombre = "Miguel Escobedo", 
            Titulo = "todologo"
            };
        return emp;
        }
    }
}
