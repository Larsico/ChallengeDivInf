using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic.CompilerServices;

namespace ClinicaSys.Data.Models
{
    public class Consulta
    {
        [Required] 
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        
        public decimal Costo { get; set; }
        public decimal CostoMateriales { get; set; }

        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }

    }
}
