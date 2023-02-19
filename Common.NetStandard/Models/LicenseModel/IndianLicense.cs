using System;

namespace Common.NetStandard.Models.LicenseModel
{

    public class IndianLicense : DomainObject
    {
        public IndianLicense() : base(0)
        {

        }

        public IndianLicense(string key, LicenseStatus licenseStatus,
            LicenseType licenseType, int id, DateTime whenItWasRegistered, bool isRegistered, int totalKeys, int keysRegistered) : base(id)
        {
            Key = key;
            LicenseStatus = licenseStatus;
            LicenseType = licenseType;
            WhenItWasRegistered = whenItWasRegistered;
            IsRegistered = isRegistered;
            TotalKeys = totalKeys;
            KeysRegistered = keysRegistered;
        }

        public int TotalKeys { get; set; }
        public int KeysRegistered { get; set; }

        public DateTime WhenItWasRegistered { get; set; }
        public bool IsRegistered { get; set; }

        public string Key { get; set; }

        public LicenseStatus LicenseStatus { get; set; }

        public LicenseType LicenseType { get; set; }


    }

}
