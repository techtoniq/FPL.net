namespace FPL.Models
{
    public record Fixture
    {
        public int Id { get; init; } = default!;
        public int Code { get; init; } = default!;
        public int Event { get; init; } = default!;
        public bool Finished { get; init; } = default!;
        public bool FinishedProvisional { get; init; } = default!;
        public DateTime KickoffTime { get; init; } = default!;
    }
}
