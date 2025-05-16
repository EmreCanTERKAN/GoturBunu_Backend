using GoturBunu_Backend.Domain.Abstractions;

namespace GoturBunu_Backend.Domain.Entities;
public sealed class Province : Entity
{
    public string Name { get; set; } = default!;
    public string Code { get; set; } = default!;
}
