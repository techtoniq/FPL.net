namespace FPL.Models
{
    public record PlayerFixtureHistory
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
        public int Minutes { get; init; } = default!;
        public int GoalsScored { get; init; } = default!;
        public int Assists { get; init; } = default!;
        public int CleanSheets { get; init; } = default!;
        public int GoalsConceded { get; init; } = default!;
        public int OwnGoals { get; init; } = default!;
        public int PenaltiesSaved { get; init; } = default!;
        public int PenaltiesMissed { get; init; } = default!;
        public int YellowCards { get; init; } = default!;
        public int RedCards { get; init; } = default!;
        public int Saves { get; init; } = default!;
        public int Bonus { get; init; } = default!;
        public int BPS { get; init; } = default!;
        public string Influence{ get; init; } = default!;
        public string Creativity { get; init; } = default!;
        public string Threat { get; init; } = default!;
        public string ICTIndex { get; init; } = default!;
        public int Value { get; init; } = default!;
        public int TransfersBalance { get; init; } = default!;
        public int Selected { get; init; } = default!;
        public int TransfersIn { get; init; } = default!;
        public int TransfersOut { get; init; } = default!;
    }
}
