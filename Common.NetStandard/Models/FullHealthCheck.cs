using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class FullHealthCheck
    {
        public FullHealthCheck()
        {

        }
        public FullHealthCheck(HealthCheckDBO healthCheck, List<IndianUserEmployeeDBO> allIndianUserEmployees, ProgramVersionModel currentProgram)
        {
            HealthCheck = healthCheck;
            AllIndianUserEmployees = allIndianUserEmployees;
            CurrentProgram = currentProgram;
        }

        public HealthCheckDBO HealthCheck { get; set; }
        public ProgramVersionModel CurrentProgram { get; set; }
        public List<IndianUserEmployeeDBO> AllIndianUserEmployees { get; set; }


    }
}
