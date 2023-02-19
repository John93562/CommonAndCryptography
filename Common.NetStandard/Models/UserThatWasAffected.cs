namespace Common.NetStandard.Models
{
    public class UserThatWasAffected
    {
        public UserThatWasAffected(string fullName)
        {
            FullName = fullName;
        }

        public string FullName { get; set; }
    }


}
