namespace Common.NetStandard.Models
{
    public class PostNewMessage
    {
        public PostNewMessage()
        {

        }
        public PostNewMessage(string superDuperEncryptedString, MessageType messageType, int programId)
        {
            SuperDuperEncryptedString = superDuperEncryptedString;
            MessageType = messageType;
            ProgramId = programId;
        }

        public string SuperDuperEncryptedString { get; set; }

        public MessageType MessageType { get; set; }
        public int ProgramId { get; set; }
    }
}
