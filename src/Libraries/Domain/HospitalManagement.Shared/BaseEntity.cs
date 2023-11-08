using HospitalManagement.Shared.Enum;

namespace HospitalManagement.Shared;

public class BaseEntity
{
    public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    public EntityStatus Status { get; set; }
}
