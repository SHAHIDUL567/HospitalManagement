using AutoMapper;
using HospitalManagement.Infrastructure;
using HospitalManagement.Model;
using HospitalManagement.Repositories.Interface;
using HospitalManagement.Services.Model;
using HospitalManagement.Shared.CommonRepository;

namespace HospitalManagement.Repositories.Base;

public class DoctorRepository : RepositoryBase<Doctor, VMDoctor, int>, IDoctorRepository
{
    public DoctorRepository(IMapper mapper, HospitalManagementDbContext dbContext) : base(mapper, dbContext) { }


}

