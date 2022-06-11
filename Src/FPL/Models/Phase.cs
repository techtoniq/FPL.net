namespace FPL.Models
{
    public record Phase
    {
        public int Id { get; init; } = default!;
        public string Name { get; init; } = default!;
        public int StartEvent { get; init; } = default!;
        public int StopEvent { get; init; } = default!;
    }
}
