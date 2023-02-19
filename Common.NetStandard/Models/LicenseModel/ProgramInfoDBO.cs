namespace Common.NetStandard.Models.LicenseModel
{
    public class ProgramInfoDBO
    {
        public ProgramInfoDBO(int programInfoId, string latestVersionOfProgram, string license, LicenseStatus licenseStatus, string latestPathToDownload, string currentProgramVersion)
        {
            ProgramInfoId = programInfoId;
            LatestVersionOfProgram = latestVersionOfProgram;
            License = license;
            LicenseStatus = licenseStatus;
            LatestPathToDownload = latestPathToDownload;
            CurrentProgramVersion = currentProgramVersion;
        }

        public string CurrentProgramVersion { get; set; }
        public int ProgramInfoId { get; }
        public string LatestPathToDownload { get; set; }
        public string LatestVersionOfProgram { get; set; }
        public string License { get; set; }
        public LicenseStatus LicenseStatus { get; set; }


    }


}
