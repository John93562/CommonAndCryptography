using Common.NetStandard.Interfaces;
using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class GeneralMessageForIndianSupport : IMessageForIndianSupport
    {
        public GeneralMessageForIndianSupport(int id = 0,
            string senderFullName = "", MessageStatus messageStatus = MessageStatus.NotReportedYet, List<ChatLog> conversation = null)
        {
            Id = id;
            SenderFullName = senderFullName;
            HasDeveloperSeenTheMessage = false;
            Status = messageStatus;
            Conversation = conversation;
        }
        public int Id { get; set; }
        public string SenderFullName { get; set; }
        public MessageStatus Status { get; set; }

        public List<ChatLog> Conversation { get; set; }
        public bool HasDeveloperSeenTheMessage { get; set; }

    }
}
