using System.Collections.Generic;

namespace Common.NetStandard.Models.LicenseModel
{

    public class AllPrograms
    {
        public AllPrograms(IEnumerable<IndianProgram> programsList)
        {
            ProgramsList = programsList;
        }

        public IEnumerable<IndianProgram> ProgramsList { get; set; }
    }

    public class ActionRespond
    {
        public ActionRespond(ActionToDo action, bool success)
        {
            Action = action;
            Success = success;
        }

        public ActionToDo Action { get; set; }
        public bool Success { get; set; }
    }


}
