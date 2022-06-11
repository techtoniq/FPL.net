namespace FPL.Models
{
    public record FixtureStat
    {
        public string Identifier { get; init; } = default!;
        public FixtureStatValue[] A { get; init; } = default!;
        public FixtureStatValue[] H { get; init; } = default!;
    }
}
