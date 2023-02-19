namespace Common.NetStandard.Models.LicenseModel
{
    public class IndianMessage : DomainObject
    {
        public IndianMessage() : base(0)
        {

        }

        public IndianMessage(string value, Status answered, ProgramInfo programInfoOwner, MessageType messageType, int id) : base(id)
        {
            Value = value;
            Answered = answered;
            ProgramInfo = programInfoOwner;
            MessageType = messageType;
        }

        public string Value { get; set; }
        public Status Answered { get; set; }
        public ProgramInfo? ProgramInfo { get; set; }
        public int ProgramInfoId { get; set; }
        public MessageType MessageType { get; set; }
    }

}
