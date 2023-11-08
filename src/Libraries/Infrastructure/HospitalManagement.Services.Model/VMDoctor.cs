using HospitalManagement.Shared;

namespace HospitalManagement.Services.Model;

public class VMDoctor:IVm
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public string DoctorName { get; set; }
    public string DoctorSpecialization { get; set; }
    public string DoctorQualifiction { get; set; }
}