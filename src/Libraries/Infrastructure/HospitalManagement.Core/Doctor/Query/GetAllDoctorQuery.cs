using AutoMapper;
using HospitalManagement.Repositories.Interface;
using HospitalManagement.Services.Model;
using MediatR;

namespace HospitalManagement.Core.Doctor.Query;
public record GetAllDoctorQuery(): IRequest<IEnumerable<VMDoctor>>;
public class GetAllDoctorQueryHandler : IRequestHandler<GetAllDoctorQuery, IEnumerable<VMDoctor>>
{
    private readonly IDoctorRepository _DoctorRepository;
    public GetAllDoctorQueryHandler(IDoctorRepository DoctorRepository, IMapper mapper)
    {
        _DoctorRepository = DoctorRepository;
    }
    public async Task<IEnumerable<VMDoctor>>Handle(GetAllDoctorQuery request, CancellationToken cancellationToken)
    {
        var result = await _DoctorRepository.GetList();
        return result;
    }
}
