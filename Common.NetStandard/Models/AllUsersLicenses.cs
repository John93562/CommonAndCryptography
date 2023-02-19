using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class AllUsersLicenses
    {
        public AllUsersLicenses(IEnumerable<IndianLicenseDBO> allLicenses)
        {
            AllLicenses = allLicenses;
        }

        public IEnumerable<IndianLicenseDBO> AllLicenses { get; set; }
    }
}
