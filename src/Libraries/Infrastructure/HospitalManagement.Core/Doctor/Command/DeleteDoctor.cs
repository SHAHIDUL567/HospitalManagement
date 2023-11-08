using HospitalManagement.Repositories.Interface;
using HospitalManagement.Services.Model;
using MediatR;

namespace HospitalManagement.Core.Doctor.Command;
public record DeleteDoctor(int Id) : IRequest<VMDoctor>;
public class DeleteDoctorHandler : IRequestHandler<DeleteDoctor, VMDoctor>
{
    private readonly IDoctorRepository _doctorRepository;
   
    public DeleteDoctorHandler(IDoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }
    public async Task<VMDoctor> Handle(DeleteDoctor request, CancellationToken cancellationToken)
    {
        return await _doctorRepository.Delete(request.Id);
    }
}
