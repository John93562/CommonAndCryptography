namespace Common.NetStandard.Models.LicenseModel
{
    public class AddKeysResponse
    {
        public AddKeysResponse(int howManyKeys, int licenseId)
        {
            HowManyKeys = howManyKeys;
            LicenseId = licenseId;
        }

        public int LicenseId { get; set; }
        public int HowManyKeys { get; set; }


    }

}
