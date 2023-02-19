namespace Common.NetStandard.Models.LicenseModel
{
    public class LicenseResponseForBlocking
    {
        public LicenseResponseForBlocking(int licenseId, BlockEnum action, int programInfoId)
        {
            LicenseId = licenseId;
            Action = action;
            ProgramInfoId = programInfoId;
        }

        public int LicenseId { get; set; }
        public BlockEnum Action { get; set; }
        public int ProgramInfoId { get; set; }

    }

}
