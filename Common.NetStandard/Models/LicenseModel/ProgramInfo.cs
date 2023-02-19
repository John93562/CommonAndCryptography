using System;
using System.Collections.Generic;

namespace Common.NetStandard.Models.LicenseModel
{


    public class ProgramInfo : DomainObject
    {

        public ProgramInfo() : base(0)
        {

        }
        public ProgramInfo(ProgramVersion programVersion,
            ICollection<HealthCheck> allHealthChecks,
            ICollection<IndianUserEmployee> indianUserEmployees, int id, DateTime latestUpdateTime, ICollection<ActionToDo> allActions, ICollection<IndianMessage> usersMessages, string currentVersionOfTheProgram) : base(id)
        {
            ProgramVersion = programVersion;
            AllHealthChecks = allHealthChecks;
            IndianUserEmployees = indianUserEmployees;
            LatestUpdateTime = latestUpdateTime;
            AllActions = allActions;
            UsersMessages = usersMessages;
            CurrentVersionOfTheProgram = currentVersionOfTheProgram;
        }
        public string CurrentVersionOfTheProgram { get; set; }

        public ProgramVersion? ProgramVersion { get; set; }

        public DateTime LatestUpdateTime { get; set; }
        public ICollection<HealthCheck>? AllHealthChecks { get; set; }

        public ICollection<IndianMessage>? UsersMessages { get; set; }
        public ICollection<ActionToDo>? AllActions { get; set; }

        public ICollection<IndianUserEmployee>? IndianUserEmployees { get; set; }




    }


}
