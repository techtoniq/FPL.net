namespace FPL.Models
{
    public record PlayerFixtureHistory : PlayerStats
    {
        public int Element { get; init; } = default!;
        public int Fixture { get; init; } = default!;
        public int OpponentTeam { get; init; } = default!;
        public int TotalPoints { get; init; } = default!;
        public bool WasHome { get; init; } = default!;
        public DateTime KickoffTime { get; init; } = default!;
        public int TeamHScore { get; init; } = default!;
        public int TeamAScore { get; init; } = default!;
        public int Round { get; init; } = default!;
        public int Value { get; init; } = default!;
        public int TransfersBalance { get; init; } = default!;
        public int Selected { get; init; } = default!;
        public int TransfersIn { get; init; } = default!;
        public int TransfersOut { get; init; } = default!;
    }
}
