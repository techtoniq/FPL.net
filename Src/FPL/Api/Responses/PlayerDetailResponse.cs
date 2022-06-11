using FPL.Models;

namespace FPL.Api.Responses
{
    public record PlayerDetailResponse
    {
        public PlayerFixture[] Fixtures { get; init; } = default!;
        public PlayerFixtureHistory[] History { get; init; } = default!;
        public PlayerSeasonHistory[] HistoryPast { get; init; } = default!;
    }
}
