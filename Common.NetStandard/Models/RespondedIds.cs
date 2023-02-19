using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class RespondedIds
    {
        public RespondedIds(List<int> idsThatHaveBeenAnsweredByDeveloper)
        {
            IdsThatHaveBeenAnsweredByDeveloper = idsThatHaveBeenAnsweredByDeveloper;
        }

        public List<int> IdsThatHaveBeenAnsweredByDeveloper { get; set; }
    }

}
