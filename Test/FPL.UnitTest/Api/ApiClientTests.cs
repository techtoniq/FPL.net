using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Extensions;
using FPL.Api;
using Moq;
using Moq.Protected;
using NUnit.Framework;

namespace FPL.UnitTest.Api
{
    public class ApiClientTests
    {
        private static ApiClient CreateMockApiClient(string urlPath, string jsonResponse)
        {
            HttpResponseMessage httpResponse = new HttpResponseMessage()
            {
                Content = new StringContent(jsonResponse, System.Text.Encoding.UTF8, "application/json"),
                StatusCode = System.Net.HttpStatusCode.OK,
                RequestMessage = new HttpRequestMessage(),
            };

            Mock<HttpMessageHandler> mockHandler = new Mock<HttpMessageHandler>();
            mockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                ItExpr.Is<HttpRequestMessage>(r => r.Method == HttpMethod.Get && r.RequestUri.ToString().EndsWith(urlPath)),
                ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(httpResponse);

            HttpClient httpClient = new HttpClient(mockHandler.Object);

            return new ApiClient(httpClient);
        }

        public class Constructor
        {
            [Test]
            public void When_No_HttpClient_Provided_Then_Created_Internally()
            {
                var apiClient = new ApiClient(httpClient: null!, baseUrl: null!);
            }

            [Test]
            public void When_HttpClient_Provided_Then_Not_Created_Internally()
            {
                var httpClient = new HttpClient();
                var apiClient = new ApiClient(httpClient: httpClient, baseUrl: null!);
            }

            [Test]
            public void When_BaseUrl_Provided_Then_Used()
            {
                var apiClient = new ApiClient(httpClient: null!, baseUrl: "http://someurl/");
            }

            [Test]
            public void When_HttpClient_And_BaseUrl_Provided_Then_Used()
            {
                var httpClient = new HttpClient();
                var apiClient = new ApiClient(httpClient: httpClient, baseUrl: "http://someurl/");
            }
        }

        public class GetFixturesAsync
        {
            [Test]
            public async Task When_Valid_Json_Response_Then_Deserialize_Fixtures_Successfully()
            {
                var apiClient = CreateMockApiClient("/api/fixtures/",
                    "[{\"code\":2210271,\"event\":1,\"finished\":true,\"finished_provisional\":true,\"id\":1,\"kickoff_time\":\"2021-08-13T19:00:00Z\",\"minutes\":90,\"provisional_start_time\":false,\"started\":true,\"team_a\":1,\"team_a_score\":0,\"team_h\":3,\"team_h_score\":2,\"stats\":[{\"identifier\":\"goals_scored\",\"a\":[],\"h\":[{\"value\":1,\"element\":77},{\"value\":1,\"element\":81}]},{\"identifier\":\"assists\",\"a\":[],\"h\":[{\"value\":1,\"element\":91}]},{\"identifier\":\"own_goals\",\"a\":[],\"h\":[]},{\"identifier\":\"penalties_saved\",\"a\":[],\"h\":[]},{\"identifier\":\"penalties_missed\",\"a\":[],\"h\":[]},{\"identifier\":\"yellow_cards\",\"a\":[],\"h\":[]},{\"identifier\":\"red_cards\",\"a\":[],\"h\":[]},{\"identifier\":\"saves\",\"a\":[{\"value\":1,\"element\":1}],\"h\":[{\"value\":4,\"element\":80}]},{\"identifier\":\"bonus\",\"a\":[],\"h\":[{\"value\":3,\"element\":81},{\"value\":2,\"element\":91},{\"value\":1,\"element\":80}]},{\"identifier\":\"bps\",\"a\":[{\"value\":17,\"element\":16},{\"value\":14,\"element\":8},{\"value\":14,\"element\":10},{\"value\":13,\"element\":7},{\"value\":13,\"element\":21},{\"value\":13,\"element\":478},{\"value\":12,\"element\":67},{\"value\":11,\"element\":1},{\"value\":9,\"element\":17},{\"value\":7,\"element\":26},{\"value\":4,\"element\":22},{\"value\":4,\"element\":531},{\"value\":-2,\"element\":530}],\"h\":[{\"value\":33,\"element\":81},{\"value\":32,\"element\":91},{\"value\":30,\"element\":80},{\"value\":25,\"element\":77},{\"value\":23,\"element\":483},{\"value\":22,\"element\":76},{\"value\":22,\"element\":83},{\"value\":9,\"element\":479},{\"value\":6,\"element\":84},{\"value\":4,\"element\":78},{\"value\":4,\"element\":96},{\"value\":4,\"element\":97},{\"value\":3,\"element\":90},{\"value\":1,\"element\":88}]}],\"team_h_difficulty\":4,\"team_a_difficulty\":2,\"pulse_id\":66342}]");

                var response = await apiClient.GetFixturesAsync();

                response.Should().NotBeNull().And.HaveCount(1);
                response?[0].Code.Should().Be(2210271);
                response?[0].Event.Should().Be(1);
                response?[0].Finished.Should().Be(true);
                response?[0].FinishedProvisional.Should().Be(true);
                response?[0].Id.Should().Be(1);
                response?[0].KickoffTime.Should().Be(13.August(2021).At(19,00).AsUtc());
            }
        }
    }
}
