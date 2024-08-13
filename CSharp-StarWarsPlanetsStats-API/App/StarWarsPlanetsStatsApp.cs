using CSharp_StarWarsPlanetsStats_API.ApiDataAccess;
using CSharp_StarWarsPlanetsStats_API.DataAccess;
using CSharp_StarWarsPlanetsStats_API.DTOs;
using System.Numerics;
using System.Text.Json;

namespace CSharp_StarWarsPlanetsStats_API.App
{
    class StarWarsPlanetsStatsApp
    {
        private readonly IPlanetsReader _planetsReader;
        private readonly IPlanetsStatisticsAnalyzer _planetsStatisticsAnalyzer;

        public StarWarsPlanetsStatsApp(IPlanetsReader planetsReader, IPlanetsStatisticsAnalyzer planetsStatisticsAnalyzer)
        {
            _planetsReader = planetsReader;
            _planetsStatisticsAnalyzer = planetsStatisticsAnalyzer;
        }

        public async Task Run()
        {
            var planets = await _planetsReader.Read();

            foreach (var planet in planets)
            {
                Console.WriteLine(planet);
            }

            _planetsStatisticsAnalyzer.Analyze(planets);
        }
    }
}
