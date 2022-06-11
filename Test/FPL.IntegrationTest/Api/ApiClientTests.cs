using System.Threading.Tasks;
using FluentAssertions;
using FPL.Api;
using FPL.Api.Responses;
using NUnit.Framework;

namespace FPL.IntegrationTest.Api
{
    public class ApiClientTests
    {
        public class GetStaticAsync
        {
            [Test]
            public async Task When_Valid_Request_Then_Return_Populated_StaticResponse()
            {
                var apiClient = new ApiClient();
                
                var response = await apiClient.GetStaticAsync();

                response.Should().NotBeNull();
                response.Should().BeOfType<StaticResponse>();
                response.Elements.Should().NotBeNullOrEmpty();
                response.ElementStats.Should().NotBeNullOrEmpty();
                response.Events.Should().NotBeNullOrEmpty();
                response.GameSettings.Should().NotBeNull();
                response.Phases.Should().NotBeNullOrEmpty();
                response.Teams.Should().NotBeNullOrEmpty();
                response.TotalPlayers.Should().BeGreaterThan(0);
            }
        }

        public class GetFixturesAsync
        {
            [Test]
            public async Task When_Valid_Request_Then_Return_Populated_Array_Of_Fixtures()
            {
                var apiClient = new ApiClient();

                var response = await apiClient.GetFixturesAsync();

                response.Should().NotBeNullOrEmpty();
            }
        }

        public class GetPlayerDetailAsync
        {
            [Test]
            public async Task When_Valid_Request_Then_Return_Populated_PlayerDetailResponse()
            {
                var apiClient = new ApiClient();
                var heungMinSonId = 359;

                var response = await apiClient.GetPlayerDetailAsync(heungMinSonId);

                response.Should().NotBeNull();
                response.Should().BeOfType<PlayerDetailResponse>();
            }
        }
    }
}
