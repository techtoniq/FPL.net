using FPL.Models;

namespace FPL.Api.Responses
{
    public record PlayerDetailResponse
    {
        public Fixture[] Fixtures { get; init; } = default!;
    }
}
