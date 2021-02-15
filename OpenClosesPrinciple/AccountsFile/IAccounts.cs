using OpenClosesPrinciple.Applicants;

namespace OpenClosesPrinciple
{
    public interface IAccounts
    {
        ApplicantModel Create(IApplicantModel applicantModel);
    }
}