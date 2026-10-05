
using System;
using System.Collections.Generic;
using System.Linq;
using FlyFinder.Models;
using FlyFinder.Repositories;

namespace FlyFinder.Services
{
    public class VueloService
    {
        private readonly VueloRepository repositorio;

        public VueloService()
        {
            repositorio = new VueloRepository();
        }

        public List<Vuelo> ObtenerTodos()
        {
            return repositorio.ObtenerVuelos();
        }

        public List<Vuelo> BuscarPorRuta(string origen, string destino)
        {
            return ObtenerTodos()
                .Where(v =>
                    v.Origen.Equals(origen, StringComparison.OrdinalIgnoreCase) &&
                    v.Destino.Equals(destino, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Vuelo> FiltrarPorPrecio(decimal precioMaximo)
        {
            return ObtenerTodos()
                .Where(v => v.Precio <= precioMaximo)
                .OrderBy(v => v.Precio)
                .ToList();
        }

        public Vuelo? BuscarPorCodigo(string codigo)
        {
            return ObtenerTodos()
                .FirstOrDefault(v =>
                    v.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));
        }

        public List<Vuelo> OrdenarPorPrecio()
        {
            return ObtenerTodos()
                .OrderBy(v => v.Precio)
                .ToList();
        }
    }
}