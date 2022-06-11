namespace FPL.Models
{
    public record LiveEventElement
    {
        public int Id { get; init; } = default!;
        public LiveEventStats Stats { get; init; } = default!;
    }
}
