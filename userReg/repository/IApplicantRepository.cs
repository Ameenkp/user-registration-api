using userReg.Models;

namespace userReg.repository;

public interface IApplicantRepository
{
    IEnumerable<Applicant> GetAllApplicants();
    Applicant GetApplicantById(int applicantId);
    void SaveApplicant(Applicant applicant);
    void UpdateApplicant(int applicantId, Applicant Applicant);
    void DeleteApplicant(int applicantId);
}
