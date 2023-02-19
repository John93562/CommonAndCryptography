namespace Common.NetStandard.Models.LicenseModel
{
    public class IndianUserEmployee : DomainObject
    {
        public IndianUserEmployee() : base(0)
        {

        }

        public IndianUserEmployee(string fullName, bool isAdmin, ProgramInfo ownerProgram, IndianUserStatus indianUserEmployeeStatus, int id) : base(id)
        {
            FullName = fullName;
            IsAdmin = isAdmin;
            OwnerProgram = ownerProgram;
            IndianUserEmployeeStatus = indianUserEmployeeStatus;
        }

        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public IndianUserStatus IndianUserEmployeeStatus { get; set; }

        public ProgramInfo? OwnerProgram { get; set; }


    }


}
