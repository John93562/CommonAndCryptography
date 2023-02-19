namespace Common.NetStandard.Models
{
    public class Email
    {
        public Email(string toEmail, string displayName, string subject, string body, string fullNameOfSender)
        {
            ToEmail = toEmail;
            DisplayName = displayName;
            Subject = subject;
            Body = body;
            FullNameOfSender = fullNameOfSender;
        }

        public string ToEmail { get; set; }
        public string DisplayName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string FullNameOfSender { get; set; }
    }
}
