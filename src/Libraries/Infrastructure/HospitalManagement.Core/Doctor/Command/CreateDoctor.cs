using AutoMapper;
using HospitalManagement.Repositories.Interface;
using HospitalManagement.Services.Model;
using MediatR;

namespace HospitalManagement.Core.Doctor.Command;
public record CreateDoctor(VMDoctor VMDoctor) : IRequest<VMDoctor>;
public class CreateDoctorHandler : IRequestHandler<CreateDoctor, VMDoctor>
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IMapper _mapper;
    public CreateDoctorHandler(IDoctorRepository doctorRepository, IMapper mapper)
    {
        _doctorRepository = doctorRepository;
        _mapper = mapper;
    }
    public async Task<VMDoctor> Handle(CreateDoctor request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Doctor>(request.VMDoctor);
        return await _doctorRepository.Add(data);
    }
}
