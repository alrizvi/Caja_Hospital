using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Clases
{
    // Clase para deserializar la respuesta JSON
    public class ApiTipoServicio
    {
        public string operacion { get; set; }
        public string mensaje { get; set; }
        public List<TipoServicio> data { get; set; }
    }

    // Clase para representar el tipo de servicio
    public class TipoServicio
    {
        public int iD_Tipo_Servicio { get; set; }
        public string nombre { get; set; }
    }
}
