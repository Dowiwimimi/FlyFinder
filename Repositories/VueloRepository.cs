
using System.Collections.Generic;
using FlyFinder.Models;

namespace FlyFinder.Repositories
{
    public class VueloRepository
    {
        public List<Vuelo> ObtenerVuelos()
        {
            List<Vuelo> vuelos = new List<Vuelo>
            {
                new Vuelo
                {
                    Codigo = "V001",
                    Origen = "Guayaquil",
                    Destino = "Quito",
                    HorarioSalida = "08:30",
                    Precio = 85.00m
                },
                new Vuelo
                {
                    Codigo = "V002",
                    Origen = "Guayaquil",
                    Destino = "Cuenca",
                    HorarioSalida = "10:15",
                    Precio = 72.50m
                },
                new Vuelo
                {
                    Codigo = "V003",
                    Origen = "Quito",
                    Destino = "Guayaquil",
                    HorarioSalida = "14:00",
                    Precio = 95.00m
                },
                new Vuelo
                {
                    Codigo = "V004",
                    Origen = "Guayaquil",
                    Destino = "Quito",
                    HorarioSalida = "16:45",
                    Precio = 110.00m
                },
                new Vuelo
                {
                    Codigo = "V005",
                    Origen = "Cuenca",
                    Destino = "Quito",
                    HorarioSalida = "09:20",
                    Precio = 68.00m
                },
                new Vuelo
                {
                    Codigo = "V006",
                    Origen = "Guayaquil",
                    Destino = "Manta",
                    HorarioSalida = "07:15",
                    Precio = 59.00m
                }
            };

            return vuelos;
        }
    }
}