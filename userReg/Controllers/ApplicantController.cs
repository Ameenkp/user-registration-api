using Microsoft.AspNetCore.Mvc;
using userReg.Models;
using userReg.Models.DTO;
using userReg.service;
using userReg.utility;

namespace userReg.Controllers;

[Route("api/applicants")] // Update the route to follow RESTful conventions
[ApiController] // Add ApiController attribute
public class ApplicantController : ControllerBase
{
    private readonly IApplicantService _applicantService;
    private readonly ApplicantUtility _applicantUtility;


    public ApplicantController(IApplicantService applicantService , ApplicantUtility applicantUtility)
    {
        _applicantService = applicantService;
        _applicantUtility = applicantUtility;
    }

    [HttpGet]
    public IActionResult GetAllApplicants()
    {
        var applicants = _applicantService.GetAllApplicants();
        return Ok(applicants); // Return HTTP 200 OK with the user list
    }

    [HttpGet("{id:int}")]
    public IActionResult GetApplicantById(int id)
    {
        var user = _applicantService.GetApplicantById(id);

        if (user == null)
        {
            return NotFound(); // Return HTTP 404 Not Found if user not found
        }

        return Ok(user); // Return HTTP 200 OK with the user details
    }

    [HttpPost]
    public IActionResult CreateApplicant([FromBody] Applicant applicant)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState); // Return HTTP 400 Bad Request if model validation fails
        _applicantService.SaveApplicant(applicant);
        return CreatedAtAction(nameof(GetApplicantById), new { id = applicant.AppId }, applicant);
        // Return HTTP 201 Created with the user details and a location header pointing to the new resource

    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateUser(int id,ApplicantDto applicantDto)
    {
        var applicant = _applicantService.GetApplicantById(id);
        _applicantUtility.UpdateApplicantProperties(applicant , applicantDto);
        _applicantService.SaveApplicant(applicant);
        return CreatedAtAction(nameof(GetApplicantById), new { id = applicant.AppId }, applicant);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteUser(int id)
    {
        var applicant = _applicantService.GetApplicantById(id);

        if (applicant == null)
        {
            return NotFound(); // Return HTTP 404 Not Found if user not found
        }

        _applicantService.DeleteApplicant(id);
        return NoContent(); // Return HTTP 204 No Content on successful deletion
    }
}
