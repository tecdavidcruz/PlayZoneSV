namespace PlayZoneSV.Models
{
    public class Cancha
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public int Capacidad { get; set; }
        public bool Disponible { get; set; }
        public int IdProveedor { get; set; }
    }
}
