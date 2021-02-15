namespace OpenClosesPrinciple.Applicants
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        IAccounts AccountProcessor { get; set; }
    }
}