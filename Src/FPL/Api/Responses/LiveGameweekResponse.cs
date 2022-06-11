using FPL.Models;

namespace FPL.Api.Responses
{
    public record LiveGameweekResponse
    {
        public LiveEventElement[] Elements { get; init; } = default!;
    }
}
