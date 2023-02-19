namespace Common.NetStandard.Models.LicenseModel
{
    public class LicenseResult
    {
        public LicenseResult(LicenseResultEnum licenseResultEnum, string licenseName)
        {
            LicenseResultEnum = licenseResultEnum;
            LicenseName = licenseName;
        }

        public LicenseResultEnum LicenseResultEnum { get; set; }
        public string LicenseName { get; set; }
    }
}
