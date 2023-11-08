using AutoMapper;
using HospitalManagement.Repositories.Interface;
using HospitalManagement.Services.Model;
using MediatR;

namespace HospitalManagement.Core.Doctor.Command;
public record UpdateDoctor(int Id, VMDoctor VMDoctor) : IRequest<VMDoctor>;
public class UpdateDoctorHandler : IRequestHandler<UpdateDoctor, VMDoctor>
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IMapper _mapper;
    public UpdateDoctorHandler(IDoctorRepository doctorRepository, IMapper mapper)
    {
        _doctorRepository = doctorRepository;
        _mapper = mapper;
    }
    public async Task<VMDoctor> Handle(UpdateDoctor request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Doctor>(request.VMDoctor);
        return await _doctorRepository.Update(request.Id,data);
    }
}
