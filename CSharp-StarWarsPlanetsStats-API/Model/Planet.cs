using CSharp_StarWarsPlanetsStats_API.DTOs;
using CSharp_StarWarsPlanetsStats_API.Extensions;

namespace CSharp_StarWarsPlanetsStats_API.Model
{
    public readonly record struct Planet
    {
        public string Name { get; }
        public int Diameter { get; }
        public int? SurfaceWater { get; }
        public int? Population { get; }
        public Planet(string name, int diameter, int? surfaceWater, int? population)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Diameter = diameter;
            SurfaceWater = surfaceWater;
            Population = population;
        }

        public static explicit operator Planet(Result planetDto)
        {
            var name = planetDto.name;

            var diameter = int.Parse(planetDto.diameter);

            int? surfaceWater = planetDto.surface_water.ToIntOrNull();

            int? population = planetDto.population.ToIntOrNull();

            return new Planet(name, diameter, surfaceWater, population);
        }
    }
}
