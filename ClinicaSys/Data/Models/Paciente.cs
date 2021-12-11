namespace ClinicaSys.Data.Models
{
    public class Paciente : Persona
    {
        public int HistoriaClinica { get; set; }

        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
