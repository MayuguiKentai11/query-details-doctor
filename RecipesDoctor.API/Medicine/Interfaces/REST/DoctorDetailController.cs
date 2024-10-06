using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using RecipesDoctor.API.Medicine.Domain.Model.Queries;
using RecipesDoctor.API.Medicine.Domain.Services;
using RecipesDoctor.API.Medicine.Interfaces.REST.Resources;
using RecipesDoctor.API.Medicine.Interfaces.REST.Transform;

namespace RecipesDoctor.API.Medicine.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class DoctorDetailController(IDoctorDetailQueryService doctorDetailQueryService) : ControllerBase
{
    [HttpGet("GetAllDoctorDetailsByCmp")]
    [ProducesResponseType(typeof(IEnumerable<DoctorDetailResource>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllDoctorDetailsByCmp([FromQuery] string cmp)
    {
        try
        {
            var doctorDetails = await doctorDetailQueryService.Handle(new GetDoctorDetailsByCmpQuery(cmp));
            
            var doctorDetailResources = doctorDetails.Select(DoctorDetailResourceFromEntityAssembler.ToResourceFromEntity);

            return Ok(doctorDetailResources);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("GetAllDoctorDetailsByName")]
    [ProducesResponseType(typeof(IEnumerable<DoctorDetailResource>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllDoctorDetailsByName([FromQuery] string name)
    {
        try
        {
            var doctorDetails = await doctorDetailQueryService.Handle(new GetDoctorDetailsByNameQuery(name));
            
            var doctorDetailResources = doctorDetails.Select(DoctorDetailResourceFromEntityAssembler.ToResourceFromEntity);
            
            return Ok(doctorDetailResources);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("GetAllDoctorDetailsBySurname")]
    [ProducesResponseType(typeof(IEnumerable<DoctorDetailResource>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllDoctorDetailsBySurname([FromQuery] string surname)
    {
        try
        {
            var doctorDetails = await doctorDetailQueryService.Handle(new GetDoctorDetailsBySurnameQuery(surname));
            
            var doctorDetailResources = doctorDetails.Select(DoctorDetailResourceFromEntityAssembler.ToResourceFromEntity);
            
            return Ok(doctorDetailResources);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet("GetAllDoctorDetailsByNameAndSurname")]
    [ProducesResponseType(typeof(IEnumerable<DoctorDetailResource>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllDoctorDetailsByNameAndSurname([FromQuery] string name, [FromQuery] string surname)
    {
        try
        {
            var doctorDetails = await doctorDetailQueryService.Handle(new GetDoctorDetailsByNameAndSurnameQuery(name, surname));
            
            var doctorDetailResources = doctorDetails.Select(DoctorDetailResourceFromEntityAssembler.ToResourceFromEntity);
            
            return Ok(doctorDetailResources);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}