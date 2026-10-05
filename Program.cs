
using System;
using System.Collections.Generic;
using FlyFinder.Models;
using FlyFinder.Services;

VueloService servicio = new VueloService();
ReporteService reportes = new ReporteService();

int opcion = 0;

do
{
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine("        Sistema FlyFinder");
    Console.WriteLine("================================");
    Console.WriteLine("1. Mostrar todos los vuelos");
    Console.WriteLine("2. Buscar vuelos por ruta");
    Console.WriteLine("3. Filtrar vuelos por presupuesto");
    Console.WriteLine("4. Buscar vuelo por codigo");
    Console.WriteLine("5. Ordenar vuelos por precio");
    Console.WriteLine("6. Generar reporte");
    Console.WriteLine("7. Salir");
    Console.Write("Seleccione una opcion: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Ingrese un numero valido.");
        continue;
    }

    List<Vuelo> vuelos;

    switch (opcion)
    {
        case 1:
            vuelos = servicio.ObtenerTodos();
            MostrarVuelos(vuelos);
            break;

        case 2:
            Console.Write("Ciudad de origen: ");
            string origen = Console.ReadLine() ?? "";

            Console.Write("Ciudad de destino: ");
            string destino = Console.ReadLine() ?? "";

            vuelos = servicio.BuscarPorRuta(origen, destino);
            MostrarVuelos(vuelos);
            break;

        case 3:
            Console.Write("Presupuesto maximo: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal presupuesto)
                && presupuesto >= 0)
            {
                vuelos = servicio.FiltrarPorPrecio(presupuesto);
                MostrarVuelos(vuelos);
            }
            else
            {
                Console.WriteLine("Ingrese un precio valido.");
            }
            break;

        case 4:
            Console.Write("Codigo del vuelo: ");
            string codigo = Console.ReadLine() ?? "";

            Vuelo? vuelo = servicio.BuscarPorCodigo(codigo);

            if (vuelo != null)
            {
                MostrarVuelos(new List<Vuelo> { vuelo });
            }
            else
            {
                Console.WriteLine("No se encontro el vuelo.");
            }
            break;

        case 5:
            vuelos = servicio.OrdenarPorPrecio();
            MostrarVuelos(vuelos);
            break;

        case 6:
            reportes.MostrarReporte(servicio.ObtenerTodos());
            break;

        case 7:
            Console.WriteLine("Gracias por utilizar FlyFinder.");
            break;

        default:
            Console.WriteLine("Opcion no valida.");
            break;
    }

} while (opcion != 7);


static void MostrarVuelos(List<Vuelo> vuelos)
{
    Console.WriteLine();
    Console.WriteLine("========== Lista de vuelos  ==========");

    if (vuelos.Count == 0)
    {
        Console.WriteLine("No se encontraron vuelos.");
        return;
    }

    foreach (Vuelo vuelo in vuelos)
    {
        Console.WriteLine(
            $"{vuelo.Codigo} | {vuelo.Origen} -> {vuelo.Destino} | " +
            $"{vuelo.HorarioSalida} | ${vuelo.Precio:F2}");
    }

    Console.WriteLine($"Total de resultados: {vuelos.Count}");
}