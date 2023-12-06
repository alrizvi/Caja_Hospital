using Caja_Hospital.Data;
using Caja_Hospital.Models.Entities;
using Caja_Hospital.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Services
{
    public class EmpleadoService : IEmpleado
    {
        private HospitalDbContext _hospitalDb;

        public EmpleadoService(HospitalDbContext hospitalDb)
        {
            _hospitalDb = hospitalDb;
        }

        public async Task<ResponseRequest> LogginEmpleado(string usuario, string clave)
        {
            ResponseRequest resp = new ResponseRequest();
            try
            {
                var empleado = await _hospitalDb.Empleado.Where(emp => emp.Usuario == usuario && emp.Clave == clave).FirstOrDefaultAsync();
                if (empleado == null)
                {

                }
                return resp;
            }
            catch (Exception ex)
            {
                resp.Operacion = "fallida";
                resp.Mensaje = "Error al intentar iniciar sesion";
                resp.Data = Array.Empty<string>();
                return resp;
            }
        }
    }
}
