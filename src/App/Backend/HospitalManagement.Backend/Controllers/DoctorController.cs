using HospitalManagement.Core.Doctor.Command;
using HospitalManagement.Core.Doctor.Query;
using HospitalManagement.Services.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Backend.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DoctorController : ControllerBase
{
    private readonly IMediator _mediator;

    public DoctorController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<ActionResult<VMDoctor>> Get()
    {
        var data = await _mediator.Send(new GetAllDoctorQuery());
        return Ok(data);
    }

    [HttpGet("id")]
    public async Task<ActionResult<VMDoctor>> Get(int id)
    {
        var data = await _mediator.Send(new GetDoctorById(id));
        return Ok(data);
    }
    [HttpPost]
    public async Task<ActionResult<VMDoctor>> PostAsync([FromBody] VMDoctor vmDoctor)
    {
        var data = await _mediator.Send(new CreateDoctor(vmDoctor));
        return Ok(data);
    }
    [HttpPut("id")]
    public async Task<ActionResult<VMDoctor>> PutAsync(int id, [FromBody] VMDoctor vmDoctor)
    {
        var data = await _mediator.Send(new UpdateDoctor(id, vmDoctor));
        return Ok(data);
    }
    [HttpDelete("id")]
    public async Task<ActionResult<VMDoctor>> DeleteAsync(int id)
    {
        var data = await _mediator.Send(new DeleteDoctor(id));
        return Ok(data);

    }
}
