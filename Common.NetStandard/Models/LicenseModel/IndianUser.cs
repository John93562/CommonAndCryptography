using System.Collections.Generic;

namespace Common.NetStandard.Models.LicenseModel
{
    public class IndianUser : DomainObject
    {


        public IndianUser() : base(0)
        {

        }
        public IndianUser(string username, string password, IndianUserStatus userStatus, int id, ICollection<FullLicense> allFullLicenses, string name) : base(id)
        {
            Username = username;
            Password = password;
            UserStatus = userStatus;
            AllFullLicenses = allFullLicenses;
            Name = name;
        }

        public string Username { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }

        public ICollection<FullLicense>? AllFullLicenses { get; set; }

        public IndianUserStatus UserStatus { get; set; }

    }


}
