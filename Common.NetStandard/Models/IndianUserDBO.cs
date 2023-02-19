using Common.NetStandard.Models.LicenseModel;
using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class IndianUserDBO
    {
        public IndianUserDBO(string username, IndianUserStatus userStatus, IEnumerable<FullLicenseDBO> allFullLicensesDBO, int id, string name)
        {
            Username = username;
            UserStatus = userStatus;
            AllFullLicensesDBO = allFullLicensesDBO;
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public IndianUserStatus UserStatus { get; set; }

        public IEnumerable<FullLicenseDBO> AllFullLicensesDBO { get; set; }
    }
}
