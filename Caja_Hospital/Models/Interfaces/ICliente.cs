using Caja_Hospital.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Caja_Hospital.Models.Interfaces
{
    public interface ICliente
    {
        Task<ResponseRequest> BuscarCliente(string cedula);
        Task<ResponseRequest> AgregarCliente(string nombre, string apellido, string cedula, DateTime fechaNacimiento,string sexo, string direccion = null, string telefono = null, string seguro = null, string sangre = null, string enfermedades = null, string alergias = null);
        Task<ResponseRequest> EditarCliente(string cedula);
    }
}
    