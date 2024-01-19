using System.Text.Json;
using System.Text.Json.Serialization;
using GraphQL;
using GraphQLParser;
using KitsuSharp.Objects;

namespace KitsuSharp;

public partial class KitsuClient
{
    private readonly string apiUrl = "https://kitsu.io/api";
    private HttpClient _client;
    private JsonSerializerOptions serializerOptions;

    public KitsuClient()
    {
        _client = new HttpClient();
        serializerOptions = new JsonSerializerOptions
        {
            AllowTrailingCommas = true,
            PropertyNameCaseInsensitive = true,
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
            Converters = { new JsonStringEnumConverter() }
        };
    }

    public async Task<AnimeResponse> GetAnime()
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"{apiUrl}/edge/anime"),
            /*Headers =
            {
                { "Accept", "application/json" }
            }*/
        };
        
        using var response = await _client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var animeResponse = JsonSerializer.Deserialize<AnimeResponse>(
            response.Content.ReadAsStringAsync().Result ?? throw new InvalidOperationException(), serializerOptions);
        return animeResponse;
    }
}