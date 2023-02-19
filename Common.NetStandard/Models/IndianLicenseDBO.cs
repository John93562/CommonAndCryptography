using Common.NetStandard.Models.LicenseModel;
using System;

namespace Common.NetStandard.Models
{
    public class IndianLicenseDBO
    {
        public IndianLicenseDBO(int id, DateTime whenItWasRegistered, bool isRegistered, string key, LicenseStatus licenseStatus, LicenseType licenseType, int totalKeys, int keysRegistered, string programName, string username, int programInfoId, string nameOfUser, string latestVersionName, string versionBase, int userId, string githubRepository, DateTime latestUpdateTime)
        {
            Id = id;
            WhenItWasRegistered = whenItWasRegistered;
            IsRegistered = isRegistered;
            Key = key;
            LicenseStatus = licenseStatus;
            LicenseType = licenseType;
            TotalKeys = totalKeys;
            KeysRegistered = keysRegistered;
            ProgramName = programName;
            Username = username;
            ProgramInfoId = programInfoId;
            NameOfUser = nameOfUser;
            LatestVersionName = latestVersionName;
            VersionBase = versionBase;
            UserId = userId;
            GithubRepository = githubRepository;
            LatestUpdateTime = latestUpdateTime;
        }
        public int UserId { get; set; }
        public string GithubRepository { get; set; }
        public int Id { get; set; }
        public int ProgramInfoId { get; set; }
        public string LatestVersionName { get; set; }
        public string VersionBase { get; set; }
        public string ProgramName { get; set; }
        public DateTime LatestUpdateTime { get; set; }
        public string Username { get; set; }
        public string NameOfUser { get; set; }
        public DateTime WhenItWasRegistered { get; set; }
        public bool IsRegistered { get; set; }
        public int TotalKeys { get; set; }
        public int KeysRegistered { get; set; }

        public string Key { get; set; }

        public LicenseStatus LicenseStatus { get; set; }

        public LicenseType LicenseType { get; set; }
    }
}
