using userReg.Models;
using userReg.Models.DTO;

namespace userReg.utility;

public class ApplicantUtility
{
    public void UpdateApplicantProperties(Applicant applicant, ApplicantDto applicantDto)
    {
        var applicantProperties = typeof(Applicant).GetProperties();
        foreach (var property in applicantProperties)
        {
            // Check if the property exists in the DTO and is not null
            if (applicantDto.GetType().GetProperty(property.Name) is { } dtoProperty
                && dtoProperty.GetValue(applicantDto) != null)
            {
                // Set the value of the property in the entity
                property.SetValue(applicant, dtoProperty.GetValue(applicantDto));
            }
        }
    }
}