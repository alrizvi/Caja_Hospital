using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Hospital.Models.Entities
{
    public class ClienteModel
    {
        [Key]
        public int Id_Cliente { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Index(IsUnique = true)]
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        public string Seguro { get; set; }
        public string Sexo { get; set; }
        public string Sangre { get; set; }
        public string Enfermedades { get; set; }
        public string Alergias { get; set; }
        public List<TransaccionModel> Transacciones { get; set; }
    }
}
