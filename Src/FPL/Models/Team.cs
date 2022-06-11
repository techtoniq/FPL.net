namespace FPL.Models
{
    public record Team
    {
        public int Code { get; init; } = default!;
        public int Draw { get; init; } = default!;
        public string Form { get; init; } = default!;
        public int Id { get; init; } = default!;
        public int Loss { get; init; } = default!;
        public string Name { get; init; } = default!;
        public int Played { get; init; } = default!;
        public int Points { get; init; } = default!;
        public int Position { get; init; } = default!;
        public string ShortName { get; init; } = default!;
        public int Strength { get; init; } = default!;
        public string TeamDivision { get; init; } = default!;
        public bool Unavailable{ get; init; } = default!;
        public int Win { get; init; } = default!;
        public int StrengthOverallHome { get; init; } = default!;
        public int StrengthOverallAway { get; init; } = default!;
        public int StrengthAttackHome { get; init; } = default!;
        public int StrengthAttackAway { get; init; } = default!;
        public int StrengthDefenceHome { get; init; } = default!;
        public int StrengthDefenceAway { get; init; } = default!;
        public int PulseId { get; init; } = default!;
    }
}
