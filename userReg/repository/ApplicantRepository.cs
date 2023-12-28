using Microsoft.EntityFrameworkCore;
using userReg.data;
using userReg.Models;

namespace userReg.repository;

public class ApplicantRepository : IApplicantRepository
{
    private readonly ApplicantDbContext _dbContext;

    public ApplicantRepository(ApplicantDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Applicant> GetAllApplicants()
    {
        return _dbContext.Applicants.ToList();
    }

    public Applicant GetApplicantById(int applicantId)
    {
        return _dbContext.Applicants.Find(applicantId);
    }

    public void SaveApplicant(Applicant applicant)
    {
        if (applicant.AppId == 0)
        {
            // New Applicant, add to the database
            _dbContext.Applicants.Add(applicant);
        }
        else
        {
            // Existing Applicant, update in the database
            // _dbContext.Entry(applicant).State = EntityState.Modified;
            _dbContext.Applicants.Update(applicant);
        }

        _dbContext.SaveChanges();
    }
    
    public void UpdateApplicant(int applicantId , Applicant applicant)
    {
        var findInDb = _dbContext.Applicants.Find(applicantId);
        if (findInDb == null) return;
        SaveApplicant(applicant);
    }

    public void DeleteApplicant(int applicantId)
    {
        var applicant = _dbContext.Applicants.Find(applicantId);
        if (applicant == null) return;
        _dbContext.Applicants.Remove(applicant);
        _dbContext.SaveChanges();
    }
}
