using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Clases
{
    public class Cliente
    {
        public int id_Cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public DateTime fecha_Nacimiento { get; set; }
        public string seguro { get; set; }
        public string sexo { get; set; }
        public string sangre { get; set; }
        public string enfermedades { get; set; }
        public string alergias { get; set; }
        public DateTime fecha_Ingreso { get; set; }
    }

    // Clase para deserializar la respuesta JSON
    public class ClienteResponse
    {
        public string operacion { get; set; }
        public string mensaje { get; set; }
        public ClienteData data { get; set; }
    }

    // Clase para representar los datos del cliente en la respuesta JSON
    public class ClienteData
    {
        public int id_Cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        // Otras propiedades del cliente según sea necesario
    }
}
