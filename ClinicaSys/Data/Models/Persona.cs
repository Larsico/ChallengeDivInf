using System.ComponentModel.DataAnnotations;

namespace ClinicaSys.Data.Models
{
    public abstract class Persona
    {
        [Required]
        public int Id { get; set; }
        public string Nombre { get; set; }

    }
}
