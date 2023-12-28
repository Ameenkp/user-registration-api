using userReg.Models;
using userReg.Models.DTO;

namespace userReg.service;

public interface IApplicantService
{
    IEnumerable<Applicant> GetAllApplicants();
    Applicant GetApplicantById(int applicantId);
    void SaveApplicant(Applicant applicant);
    void UpdateApplicant(int applicantId, Applicant user);
    void DeleteApplicant(int applicantId);
}
