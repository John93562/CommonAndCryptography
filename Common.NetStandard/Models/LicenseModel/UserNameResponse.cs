namespace Common.NetStandard.Models.LicenseModel
{
    public class UserNameResponse
    {

        public UserNameResponse(string userName, string licenseStatus)
        {
            UserName = userName;
            LicenseStatus = licenseStatus;

        }

        public string UserName { get; set; }
        public string LicenseStatus { get; set; }


    }
}
