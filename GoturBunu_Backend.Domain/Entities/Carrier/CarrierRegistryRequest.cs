using GoturBunu_Backend.Domain.Abstractions;
using GoturBunu_Backend.Domain.Enums;

namespace GoturBunu_Backend.Domain.Entities.Carrier;
public sealed class CarrierRegistryRequest : Entity
{
    public string Name { get; set; } = default!;
    public string SurName { get; set; } = default!;
    public string NationalIdentityNumber { get; set; } = default!;
    public string Phone { get; set; } = default!;
    public string Email { get; set; } = default!;
    public ERegisteryRequestStatus Status { get; set; } = ERegisteryRequestStatus.Pending;
    public string DistrictId { get; set; } = default!;
    public District District { get; set; } = default!;
}
