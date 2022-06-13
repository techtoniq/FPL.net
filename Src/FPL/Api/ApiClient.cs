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

        public ApiClient(HttpClient httpClient = null!, string baseUrl = null!)
        {
            if(null == httpClient)
            {
                httpClient = new HttpClient();
            }
            if(string.IsNullOrWhiteSpace(baseUrl))
            {
                baseUrl = "https://fantasy.premierleague.com";
            }
            httpClient.BaseAddress = new Uri(baseUrl);
            _restClient = new RestClient(httpClient);
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
        public async Task<LiveGameweekResponse?> GetLiveGameweekAsync(int id)
        {
            return await _restClient.GetAsync<LiveGameweekResponse>(new RestRequest($"/api/event/{id}/live/"));
        }
    }
}
