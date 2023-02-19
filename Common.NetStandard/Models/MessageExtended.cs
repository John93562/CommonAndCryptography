namespace Common.NetStandard.Models
{
    public class MessageExtended
    {
        public MessageExtended(string value, MessageType messageType, int id)
        {
            Value = value;
            MessageType = messageType;
            Id = id;
        }

        public int Id { get; set; }

        public string Value { get; set; }
        public MessageType MessageType { get; set; }

    }
}
