using CSharp_StarWarsPlanetsStats_API.Model;

namespace CSharp_StarWarsPlanetsStats_API.App
{
    public interface IPlanetsStatisticsAnalyzer
    {
        void Analyze(IEnumerable<Planet> planets);
    }
}
