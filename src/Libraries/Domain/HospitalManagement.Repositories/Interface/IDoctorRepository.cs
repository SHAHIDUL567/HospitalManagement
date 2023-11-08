using HospitalManagement.Model;
using HospitalManagement.Services.Model;
using HospitalManagement.Shared.CommonRepository;

namespace HospitalManagement.Repositories.Interface;

public interface IDoctorRepository : IRepository<Doctor, VMDoctor, int>
{
   
}
