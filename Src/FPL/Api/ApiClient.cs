using System.Text.Json;
using FPL.Api.Responses;
using FPL.Models;
using FPL.Policies;
using RestSharp;
using RestSharp.Serializers.Json;

namespace FPL.Api
{
    public class ApiClient
    {
        private readonly RestClient _restClient;

        public ApiClient(string baseUrl = "https://fantasy.premierleague.com")
        {
            _restClient = new RestClient(baseUrl);
            _restClient.UseSystemTextJson(new JsonSerializerOptions { PropertyNamingPolicy = new SnakeCaseNamingPolicy() });
        }

        public async Task<StaticResponse?> GetStaticAsync()
        {
            return await _restClient.GetAsync<StaticResponse>(new RestRequest("/api/bootstrap-static/"));
        }

        public async Task<Fixture[]?> GetFixturesAsync()
        {
            return await _restClient.GetAsync<Fixture[]>(new RestRequest("/api/fixtures/"));
        }

        public async Task<PlayerDetailResponse?> GetPlayerDetailAsync(int id)
        {
            return await _restClient.GetAsync<PlayerDetailResponse>(new RestRequest($"/api/element-summary/{id}/"));
        }
    }
}
