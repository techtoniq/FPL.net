namespace FPL.Models
{
    public record ElementType
    {
        public int Id { get; init; } = default!;
        public string PluralName { get; init; } = default!;
        public string PluralNameShort { get; init; } = default!;
        public string SingularName { get; init; } = default!;
        public string SingularNameShort { get; init; } = default!;
        public int SquadSelect { get; init; } = default!;
        public int SquadMinPlay { get; init; } = default!;
        public int SquadMaxPlay { get; init; } = default!;
        public bool UiShirtSpecific { get; init; } = default!;
        public int[] SubPositionsLocked { get; init; } = default!;
        public int ElementCount { get; init; } = default!;
    }
}
