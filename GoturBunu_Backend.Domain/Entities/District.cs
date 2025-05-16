using GoturBunu_Backend.Domain.Abstractions;

namespace GoturBunu_Backend.Domain.Entities;
public sealed class District : Entity
{
    public string Name { get; set; } = default!;
    public Province Province { get; set; } = default!;
}
