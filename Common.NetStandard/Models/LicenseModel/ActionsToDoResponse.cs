using System.Collections.Generic;

namespace Common.NetStandard.Models.LicenseModel
{
    public class ActionsToDoResponse
    {
        public ActionsToDoResponse(IEnumerable<ActionToDoDBO> allActionsToDo)
        {
            AllActionsToDo = allActionsToDo;
        }

        public IEnumerable<ActionToDoDBO> AllActionsToDo { get; set; }

    }
}
