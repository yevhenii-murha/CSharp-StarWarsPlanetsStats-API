namespace CSharp_StarWarsPlanetsStats_API.ApiDataAccess
{
    public interface IApiDataReader
    {
        Task<string> Read(string baseAddress, string requestUri);
    }
}
