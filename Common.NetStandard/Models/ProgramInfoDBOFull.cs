using Common.NetStandard.Models.LicenseModel;
using System;
using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class ProgramInfoDBOFull
    {

        public ProgramInfoDBOFull(string versionBase, string githubRepository, string programName, DateTime latestUpdateTime,
            IEnumerable<HealthCheckDBO> allHealthChecks, IEnumerable<IndianUserEmployeeDBO> allEmployees, IEnumerable<ActionToDoDBO> allActions, int id, IEnumerable<IndianMessageDBO> allMessages, int mainProgramId, int programVersionId, string currentProgramVersion, string latestVersion)
        {
            VersionBase = versionBase;
            GithubRepository = githubRepository;
            ProgramName = programName;
            LatestUpdateTime = latestUpdateTime;
            AllHealthChecks = allHealthChecks;
            AllEmployees = allEmployees;
            AllActions = allActions;
            Id = id;
            AllMessages = allMessages;
            MainProgramId = mainProgramId;
            ProgramVersionId = programVersionId;
            CurrentProgramVersion = currentProgramVersion;
            LatestVersion = latestVersion;
        }

        public string CurrentProgramVersion { get; set; }
        public int Id { get; set; }
        public string LatestVersion { get; set; }
        public int ProgramVersionId { get; set; }
        public int MainProgramId { get; set; }
        public string VersionBase { get; set; }
        public string GithubRepository { get; set; }
        public string ProgramName { get; set; }

        public DateTime LatestUpdateTime { get; set; }

        public IEnumerable<HealthCheckDBO> AllHealthChecks { get; set; }
        public IEnumerable<IndianUserEmployeeDBO> AllEmployees { get; set; }
        public IEnumerable<ActionToDoDBO> AllActions { get; set; }

        public IEnumerable<IndianMessageDBO> AllMessages { get; set; }

    }
}
