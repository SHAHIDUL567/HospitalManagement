using HospitalManagement.Repositories.Interface;
using HospitalManagement.Services.Model;
using MediatR;

namespace HospitalManagement.Core.Doctor.Query;
public record GetDoctorById(int Id) : IRequest<VMDoctor>;
public class GetDoctorByIdHandler : IRequestHandler<GetDoctorById, VMDoctor>
{
    private readonly IDoctorRepository _doctorRepository;
    public GetDoctorByIdHandler(IDoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }
    public async Task<VMDoctor> Handle(GetDoctorById request, CancellationToken cancellationToken)
    {
        return await _doctorRepository.GetById(request.Id);
    }
}
