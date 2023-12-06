using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Models.Entities
{
    public class ResponseRequest
    {
        public string Operacion {  get; set; }
        public string Mensaje { get; set; }
        public object Data {  get; set; }
    }
}
