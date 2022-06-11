using FPL.Models;

namespace FPL.Api.Responses
{
    public record StaticResponse
    {
        public Event[] Events { get; init; } = default!;
        public GameSettings GameSettings { get; init; } = default!;
        public Phase[] Phases { get; init; } = default!;
        public Team[] Teams { get; init; } = default!;
        public int TotalPlayers { get; init; } = default!;
        public Element[] Elements { get; init; } = default!;
        public ElementStat[] ElementStats { get; init; } = default!;
    }
}
