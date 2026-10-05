
namespace FlyFinder.Models
{
    public class Vuelo
    {
        public string Codigo { get; set; } = "";
        public string Origen { get; set; } = "";
        public string Destino { get; set; } = "";
        public string HorarioSalida { get; set; } = "";
        public decimal Precio { get; set; }
    }
}