namespace Common.NetStandard.Models
{
    public class SpecificUserResponse
    {
        public SpecificUserResponse(IndianUserDBO indianUser)
        {
            IndianUser = indianUser;
        }

        public IndianUserDBO IndianUser { get; set; }
    }
}
