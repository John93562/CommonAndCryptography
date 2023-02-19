namespace Common.NetStandard.Models.LicenseModel
{
    public class CreateNewUserSimplifiedResponse
    {
        public CreateNewUserSimplifiedResponse()
        {

        }

        public CreateNewUserSimplifiedResponse(string programVersionBase, int liceensesToCreate, string username, string programName, int licenseType, string name, int totalKeysPerLicense)
        {
            ProgramVersionBase = programVersionBase;
            LicensesToCreate = liceensesToCreate;
            Username = username;
            ProgramName = programName;
            LicenseType = licenseType;
            Name = name;
            TotalKeysPerLicense = totalKeysPerLicense;
        }
        public string ProgramName { get; set; }
        public string ProgramVersionBase { get; set; }
        public int TotalKeysPerLicense { get; set; }
        public int LicensesToCreate { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }

        public int LicenseType { get; set; }
    }


}
