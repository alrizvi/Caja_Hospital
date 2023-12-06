using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Models.Entities
{
    public class ServicioModel
    {
        [Key]
        public int Id_Servicio { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public decimal Costo { get; set; }
        public string Descripcion { get; set; }
        public string Requisitos { get; set; }
        public int? Id_Tipo_Servicio { get; set; }
        public ServicioModel Serivio { get; set; }
        public List<TransaccionModel> Transacciones { get; set;}

    }
}
