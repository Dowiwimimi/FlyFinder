
using System;
using System.Collections.Generic;
using System.Linq;
using FlyFinder.Models;

namespace FlyFinder.Services
{
    public class ReporteService
    {
        public void MostrarReporte(List<Vuelo> vuelos)
        {
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("       Reporte de vuelos ");
            Console.WriteLine("================================");

            if (vuelos.Count == 0)
            {
                Console.WriteLine("No hay vuelos para generar el reporte.");
                return;
            }

            decimal precioMinimo = vuelos.Min(v => v.Precio);
            decimal precioMaximo = vuelos.Max(v => v.Precio);
            decimal precioPromedio = vuelos.Average(v => v.Precio);

            Console.WriteLine($"Total de vuelos: {vuelos.Count}");
            Console.WriteLine($"Precio mas bajo: ${precioMinimo:F2}");
            Console.WriteLine($"Precio mas alto: ${precioMaximo:F2}");
            Console.WriteLine($"Precio promedio: ${precioPromedio:F2}");

            Console.WriteLine("================================");
        }
    }
}