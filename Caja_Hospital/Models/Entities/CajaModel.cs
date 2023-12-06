using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Models.Entities
{
    public class CajaModel
    {
        [Key]
        public int Id_Caja { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public decimal Monto_Inicial {  get; set; }
        public decimal Monto_Actual { get; set; }
        public int? Id_Empleado { get; set; }
        public EmpleadoModel Empleado { get; set; }


    }
}
