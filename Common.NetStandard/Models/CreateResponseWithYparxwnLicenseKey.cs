using Common.NetStandard.Models.LicenseModel;

namespace Common.NetStandard.Models
{
    public class CreateResponseWithYparxwnLicenseKey
    {
        public CreateResponseWithYparxwnLicenseKey()
        {

        }
        public CreateResponseWithYparxwnLicenseKey(CreateNewUserSimplifiedResponse value, string licenseKey)
        {
            Value = value;
            LicenseKey = licenseKey;
        }
        public string LicenseKey { get; set; }
        public CreateNewUserSimplifiedResponse Value { get; set; }
    }
}