namespace Common.NetStandard.Models
{
    public class SpecificLicenseResponse
    {
        public SpecificLicenseResponse(IndianLicenseDBO indianLicense)
        {
            IndianLicense = indianLicense;
        }

        public IndianLicenseDBO IndianLicense { get; set; }
    }
}
