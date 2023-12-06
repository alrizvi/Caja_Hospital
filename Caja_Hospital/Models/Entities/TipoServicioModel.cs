using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Models.Entities
{
    public class TipoServicioModel
    {
        [Key]
        public int Id_Tipo_Servicio {  get; set; }
        [Required]
        public string Nombre { get; set; }
        public List<ServicioModel> Servicios { get; set; }

    }
}
