using OpenClosesPrinciple.Applicants;

namespace OpenClosesPrinciple
{
    public class ManagerAccounts : IAccounts
    {
        public ApplicantModel Create(IApplicantModel applicantModel)
        {
            ApplicantModel output = new();

            output.FirstName = applicantModel.FirstName;
            output.LastName = applicantModel.LastName;
            output.EmailAddress = $"{ applicantModel.FirstName.Substring(0, 1) }{applicantModel.LastName}@ABCmanagment.com";

            output.IsManager = true;

            return output;
        }
    }
}
