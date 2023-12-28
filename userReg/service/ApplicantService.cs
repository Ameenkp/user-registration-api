using userReg.Models;
using userReg.repository;

namespace userReg.service;

public class ApplicantService : IApplicantService
{
    private readonly IApplicantRepository _applicantRepository;

    public ApplicantService(IApplicantRepository applicantRepository)
    {
        _applicantRepository = applicantRepository;
    }

    public IEnumerable<Applicant> GetAllApplicants()
    {
        return _applicantRepository.GetAllApplicants();
    }

    public Applicant GetApplicantById(int applicantId)
    {
        return _applicantRepository.GetApplicantById(applicantId);
    }

    public void SaveApplicant(Applicant applicant)
    {
        _applicantRepository.SaveApplicant(applicant);
    }
    
    public void UpdateApplicant(int applicantId, Applicant applicant)
    {
        _applicantRepository.UpdateApplicant(applicantId , applicant);
    }

    public void DeleteApplicant(int applicantId)
    {
        _applicantRepository.DeleteApplicant(applicantId);
    }
}
