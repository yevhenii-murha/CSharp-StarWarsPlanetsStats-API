using CSharp_StarWarsPlanetsStats_API.ApiDataAccess;
using CSharp_StarWarsPlanetsStats_API.App;
using CSharp_StarWarsPlanetsStats_API.DataAccess;

try
{
    var app = new StarWarsPlanetsStatsApp(
        new PlanetsFromApiReader(
            new ApiDataReader()),
        new PlanetsStatisticsAnalyzer());
    await app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Exception message: " + ex.Message);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();
