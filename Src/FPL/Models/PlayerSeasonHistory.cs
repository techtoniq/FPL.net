namespace FPL.Models
{
    public record PlayerSeasonHistory : PlayerStats
    {
        public string SeasonName { get; init; } = default!;
        public int ElementCode { get; init; } = default!;
        public int StartCost { get; init; } = default!;
        public int EndCost { get; init; } = default!;
        public int TotalPoints { get; init; } = default!;
    }
}
