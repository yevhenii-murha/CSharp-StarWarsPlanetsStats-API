using CSharp_StarWarsPlanetsStats_API.Model;

namespace CSharp_StarWarsPlanetsStats_API.App
{
    public class PlanetsStatisticsAnalyzer : IPlanetsStatisticsAnalyzer
    {
        public void Analyze(IEnumerable<Planet> planets)
        {
            Console.WriteLine();
            Console.WriteLine("The statistics of which property would you like to see?");
            Console.WriteLine("population");
            Console.WriteLine("diameter");
            Console.WriteLine("surface water");

            var userChoice = Console.ReadLine();
            userChoice = userChoice?.ToLower();
            if (userChoice == "population")
            {
                ShowStatistics(planets, "population", planet => planet.Population);
            }
            else if (userChoice == "diameter")
            {
                ShowStatistics(planets, "diameter", planet => planet.Diameter);
            }
            else if (userChoice == "surface water")
            {
                ShowStatistics(planets, "surface water", planet => planet.SurfaceWater);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        private static void ShowStatistics(IEnumerable<Planet> planets,
            string propertyName,
            Func<Planet, int?> property)
        {
            var planetWithMaxProperty = planets.MaxBy(property);
            var planetWithMinProperty = planets.MinBy(property);
            Console.WriteLine($"Max {propertyName} is {property(planetWithMaxProperty)} ({planetWithMaxProperty.Name})");
            Console.WriteLine($"Min {propertyName} is {property(planetWithMinProperty)} ({planetWithMinProperty.Name})");
        }
    }
}
