namespace FPL.Models
{
    public record LiveEventExplain
    {
        public int Fixture { get; init; } = default!;
        public LiveEventExplainStat[] Stats { get; init; } = default!;
    }
}
