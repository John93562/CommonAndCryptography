namespace Common.NetStandard.Models
{
    public class IndianMessageDBO
    {
        public IndianMessageDBO(int id, string value, Status answered, MessageType messageType, string username, string programName, int programInfoId, int ownerId)
        {
            Id = id;
            Value = value;
            Answered = answered;
            MessageType = messageType;
            Username = username;
            ProgramName = programName;
            ProgramInfoId = programInfoId;
            OwnerId = ownerId;
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public int OwnerId { get; set; }
        public string Username { get; set; }
        public string ProgramName { get; set; }
        public int ProgramInfoId { get; set; }
        public Status Answered { get; set; }

        public MessageType MessageType { get; set; }
    }
}
