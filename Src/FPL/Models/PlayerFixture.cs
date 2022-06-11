namespace FPL.Models
{
    public record PlayerFixture
    {
        public int Id { get; init; } = default!;
        public int Code { get; init; } = default!;
        public int TeamH { get; init; } = default!;
        public int TeamHScore { get; init; } = default!;
        public int TeamA { get; init; } = default!;
        public int TeamAScore { get; init; } = default!;
        public int Event { get; init; } = default!;
        public bool Finished { get; init; } = default!;
        public int Minutes { get; init; } = default!;
        public bool ProvisionalStartTime { get; init; } = default!;
        public DateTime KickoffTime { get; init; } = default!;
        public string EventName { get; init; } = default!;
        public bool IsHome { get; init; } = default!;
        public int Difficulty { get; init; } = default!;
    }
}
