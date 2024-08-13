using CSharp_StarWarsPlanetsStats_API.Model;

namespace CSharp_StarWarsPlanetsStats_API.DataAccess
{
    public interface IPlanetsReader
    {
        Task<IEnumerable<Planet>> Read();
    }
}
