namespace Common.NetStandard.Models.LicenseModel
{
    public class RegisterNewLicenseResponse
    {
        public RegisterNewLicenseResponse(IndianUser UserToRegisterLicense, string versionBase, int totalLicenses, int licenseType, string programName, int totalKeys)
        {
            this.UserToRegisterLicense = UserToRegisterLicense;
            VersionBase = versionBase;
            TotalLicenses = totalLicenses;
            LicenseType = licenseType;
            ProgramName = programName;
            TotalKeys = totalKeys;
        }

        public IndianUser UserToRegisterLicense { get; set; }
        public string VersionBase { get; set; }

        public string ProgramName { get; set; }
        public int TotalKeys { get; set; }
        public int TotalLicenses { get; set; }

        public int LicenseType { get; set; }
    }
}
