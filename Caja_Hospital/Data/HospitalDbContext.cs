using Caja_Hospital.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext() : base("")
        {

        }

        //public DbSet<Actividad> Actividad { get; set; }
        public DbSet<CajaModel> Caja { get; set; }
        public DbSet<ClienteModel> Cliente { get; set;}
        public DbSet<EmpleadoModel> Empleado { get; set; }
        public DbSet<ServicioModel> Servicio { get; set; }
        public DbSet<TipoServicioModel> TipoServicio { get;set; }
        public DbSet<TransaccionModel> Transaccion { get; set; }
    }
}
