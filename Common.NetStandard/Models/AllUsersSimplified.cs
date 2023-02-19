using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class AllUsersSimplified
    {
        public AllUsersSimplified(IEnumerable<UserSimplified> allUsers)
        {
            AllUsers = allUsers;
        }

        public IEnumerable<UserSimplified> AllUsers { get; set; }

    }
}
