namespace Common.NetStandard.Models
{
    public class EmailWithMessage
    {
        public EmailWithMessage(string FullName, string email, bool status, string message)
        {
            this.FullName = FullName;
            Email = email;
            Success = status;
            Message = message;
            if (Success)
            {
                SuccessText = "Ναι";
            }
            else
            {
                SuccessText = "Όχι";
            }
        }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Success { get; set; }
        public string SuccessText { get; set; }
        public string Message { get; set; }

    }
}
