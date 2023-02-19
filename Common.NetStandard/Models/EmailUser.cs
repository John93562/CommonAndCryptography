namespace Common.NetStandard.Models
{
    public class EmailUser
    {
        public EmailUser(string email, string displayName, string emailPassword)
        {
            Email = email;
            DisplayName = displayName;
            EmailPassword = emailPassword;
        }

        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string EmailPassword { get; set; }
    }
}
