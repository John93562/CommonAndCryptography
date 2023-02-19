namespace Common.NetStandard.Models.LicenseModel
{
    public class ProgramVersion : DomainObject
    {
        public ProgramVersion() : base(0)
        {

        }
        public ProgramVersion(IndianProgram ownerProgram, string versionBase, string latestVersionName, string githubRepository, int id) : base(id)
        {
            OwnerProgram = ownerProgram;
            VersionBase = versionBase;
            LatestVersionName = latestVersionName;
            GithubRepository = githubRepository;
        }

        public IndianProgram? OwnerProgram { get; set; }
        public string VersionBase { get; set; }
        public string LatestVersionName { get; set; }
        public string GithubRepository { get; set; }



    }
}
