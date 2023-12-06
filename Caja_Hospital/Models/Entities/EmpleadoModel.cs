using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Models.Entities
{
    public class EmpleadoModel
    {
        [Key]
        public int? Id_Empleado { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public string CorreoElectronico { get; set; }
        [Required]
        public string Telefono { get; set; }
        public DateTime? FechaIngreso { get; set; }
        [Index(IsUnique = true)]
        public string Usuario { get; set; }
        public string Clave { get; set; }
        [Required]
        public int? IdCaja {  get; set; }
        //public List<Actividad> Actividades { get; set; }
        //public List<Transaccion> Transacciones { get; set;}
       
    }
}
