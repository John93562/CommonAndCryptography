using Common.NetStandard.Models.LicenseModel;

namespace Common.NetStandard.Models
{
    public class IndianUserEmployeeDBO
    {
        public IndianUserEmployeeDBO(int id, string fullName, bool isAdmin, IndianUserStatus indianUserEmployeeStatus, int programInfoId = 0)
        {
            Id = id;
            FullName = fullName;
            IsAdmin = isAdmin;
            IndianUserEmployeeStatus = indianUserEmployeeStatus;
            ProgramInfoId = programInfoId;
        }
        public int ProgramInfoId { get; set; }
        public int Id { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public IndianUserStatus IndianUserEmployeeStatus { get; set; }

    }
}
