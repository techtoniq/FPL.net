namespace FPL.Models
{
    public record LiveEventExplainStat
    {
        public string Identifier{ get; init; } = default!;
        public int Points { get; init; } = default!;
        public int Value { get; init; } = default!;
    }
}
