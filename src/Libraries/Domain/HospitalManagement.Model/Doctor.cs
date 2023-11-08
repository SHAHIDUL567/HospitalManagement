using HospitalManagement.Shared;

namespace HospitalManagement.Model;

public class Doctor: BaseEntity,IEntity
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public string? DoctorName { get; set; }
    public string? DoctorSpecialization { get; set; }
    public string? DoctorQualifiction { get; set;}

}
