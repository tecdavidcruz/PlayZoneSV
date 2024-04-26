namespace PlayZoneSV.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdCancha { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
    }
}
