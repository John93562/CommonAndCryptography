namespace Common.NetStandard.Models.LicenseModel
{
    public class PathToFullyUpdatedSetup
    {
        public PathToFullyUpdatedSetup(UserNameResponse userNameResponse, string fullPath, string version)
        {
            UserNameResponse = userNameResponse;
            FullPath = fullPath;
            Version = version;
        }

        public UserNameResponse UserNameResponse { get; set; }
        public string FullPath { get; set; }

        public string Version { get; set; }
    }
}
