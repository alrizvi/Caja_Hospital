using Caja_Hospital.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Models.Interfaces
{
    public interface IServicio
    {
        Task<ResponseRequest> ListarServicios();
    }
}
