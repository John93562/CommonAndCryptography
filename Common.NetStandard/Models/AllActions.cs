using Common.NetStandard.Models.LicenseModel;
using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class AllActions
    {
        public AllActions(IEnumerable<ActionToDoDBO> actions)
        {
            Actions = actions;
        }

        public IEnumerable<ActionToDoDBO> Actions { get; set; }

    }
}
