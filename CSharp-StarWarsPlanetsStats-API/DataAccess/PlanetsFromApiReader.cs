using CSharp_StarWarsPlanetsStats_API.ApiDataAccess;
using CSharp_StarWarsPlanetsStats_API.DTOs;
using CSharp_StarWarsPlanetsStats_API.Model;
using System.Text.Json;

namespace CSharp_StarWarsPlanetsStats_API.DataAccess
{
    public class PlanetsFromApiReader : IPlanetsReader
    {
        private readonly IApiDataReader _apiDataReader;

        public PlanetsFromApiReader(IApiDataReader apiDataReader)
        {
            _apiDataReader = apiDataReader;
        }

        public async Task<IEnumerable<Planet>> Read()
        {
            string? json = null;
            try
            {
                json = await _apiDataReader.Read(
                    "https://swapi.dev/",
                    "api/planets");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("API request was unsuccessful." +
                    "Exception message: " + ex.Message);
            }

            var root = JsonSerializer.Deserialize<Root>(json);

            return ToPlanets(root);
        }

        private static IEnumerable<Planet> ToPlanets(Root? root)
        {
            if (root == null)
                throw new ArgumentNullException(nameof(root));

            var planets = new List<Planet>();

            foreach (var planetDto in root.results)
            {
                Planet planet = (Planet)planetDto;
                planets.Add(planet);
            }

            return planets;
        }
    }
}
