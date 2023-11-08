using AutoMapper;
using HospitalManagement.Services.Model;

namespace HospitalManagement.Core.Mapper;

public class CommonMapper: Profile
{
    public CommonMapper()
    {
        CreateMap<VMDoctor, Model.Doctor>().ReverseMap();
    }
}
