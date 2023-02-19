namespace Common.NetStandard.Models
{
    public class UpdateConversationMessage
    {
        public UpdateConversationMessage()
        {

        }
        public UpdateConversationMessage(string value, int id)
        {
            Value = value;
            Id = id;
        }

        public string Value { get; set; }
        public int Id { get; set; }

    }
}
