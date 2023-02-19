namespace Common.NetStandard.Models.LicenseModel
{
    public class LicenseResponse
    {
        public LicenseResponse()
        {

        }
        public LicenseResponse(string license, int programInfoId, int licenseId)
        {
            License = license;
            LicenseId = licenseId;
            ProgramInfoId = programInfoId;
        }

        public string License { get; set; }
        public int LicenseId { get; set; }

        public int ProgramInfoId { get; set; }
    }
}
