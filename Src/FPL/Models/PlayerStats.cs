namespace FPL.Models
{
    public abstract record PlayerStats
    {
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
        public string Influence { get; init; } = default!;
        public string Creativity { get; init; } = default!;
        public string Threat { get; init; } = default!;
        public string ICTIndex { get; init; } = default!;
    }
}
