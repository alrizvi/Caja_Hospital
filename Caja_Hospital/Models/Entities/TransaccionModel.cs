using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Models.Entities
{
    public class TransaccionModel
    {
        [Key]
        public int Id_Transaccion { get; set; }
        [Required]
        public decimal Monto { get; set; }
        [Required]
        public decimal MontoCaja {  get; set; }
        public DateTime FechaPago { get; set; }
        public bool Realizada {  get; set; }
        [Required]
        public int Id_Empleado { get; set; }
        public EmpleadoModel Empleado { get; set; }
        [Required]
        public int Id_Cliente { get; set; }
        public ClienteModel Cliente { get; set; }
        [Required]
        public int Id_Servicio { get; set; }
        public ServicioModel Servicio { get; set; }
    }
}
