namespace FPL.Models
{
    public record ChipPlay
    {
        public string ChipName { get; init; } = default!;
        public int NumPlayed { get; init; } = default!;
    }
}
