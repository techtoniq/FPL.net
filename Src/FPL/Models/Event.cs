namespace FPL.Models
{
    public record Event
    {
        public int Id { get; init; } = default!;
        public string Name { get; init; } = default!;
        public DateTime DeadlineTime { get; init; } = default!;
        public int AverageEntryScore { get; init; } = default!;
        public bool Finished { get; init; } = default!;
        public bool DateChecked { get; init; } = default!;
        public int HighestScoringEntry { get; init; } = default!;
        public long DeadlineTimeEpoch { get; init; } = default!;
        public int DeadlineTimeGameOffset { get; init; } = default!;
        public int HighestScore { get; init; } = default!;
        public bool IsPrevious { get; init; } = default!;
        public bool IsCurrent { get; init; } = default!;
        public bool IsNext { get; init; } = default!;
        public ChipPlay[] ChipPlays { get; init; } = default!;
        public int MostSelected { get; init; } = default!;
        public int MostTransferredIn { get; init; } = default!;
        public int TopElement { get; init; } = default!;
        public TopElementInfo TopElementInfo { get; init; } = default!;
        public int TransfersMade { get; init; } = default!;
        public int MostCaptained { get; init; } = default!;
        public int MostViceCaptained { get; init; } = default!;
    }
}
