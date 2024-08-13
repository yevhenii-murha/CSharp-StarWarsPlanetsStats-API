using System.Text.Json.Serialization;

namespace CSharp_StarWarsPlanetsStats_API.DTOs
{
    public record Root(
        [property: JsonPropertyName("count")] int count,
        [property: JsonPropertyName("next")] string next,
        [property: JsonPropertyName("previous")] object previous,
        [property: JsonPropertyName("results")] IReadOnlyList<Result> results
    );
}