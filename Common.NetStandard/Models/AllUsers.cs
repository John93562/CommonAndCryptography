using System.Collections.Generic;

namespace Common.NetStandard.Models
{



    public class AllUsers
    {
        public AllUsers(IEnumerable<IndianUserDBO> allIndians)
        {
            AllIndians = allIndians;
        }

        public IEnumerable<IndianUserDBO> AllIndians { get; set; }
    }
}
