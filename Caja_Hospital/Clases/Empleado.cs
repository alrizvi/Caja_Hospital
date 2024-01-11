using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Clases
{
    public class Empleado
    {
        public string operacion { get; set; }
        public string mensaje { get; set; }
        public EmpleadoData data { get; set; }
    }

    public class EmpleadoData
    {
        public int id_Empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public DateTime fecha_Ingreso { get; set; }
        public string clave { get; set; }
        public int iD_Caja { get; set; }
    }
}