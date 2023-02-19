using Common.NetStandard.Interfaces;
using System;

namespace Common.NetStandard.Models
{
    public class IdeaMessageForIndianSupport : IMessageForIndianSupport
    {

        public IdeaMessageForIndianSupport(
             DateTime date,
             int id = 0,
            string title = "",
            string problemDescription = "",
            string senderFullName = "", MessageStatus messageStatus = MessageStatus.NotReportedYet)
        {
            Id = id;
            Title = title;
            Description = problemDescription;
            SenderFullName = senderFullName;
            Date = date;
            HasDeveloperSeenTheMessage = false;
            Status = messageStatus;
        }
        public DateTime Date { get; set; }
        public MessageStatus Status { get; set; }
        public bool HasDeveloperSeenTheMessage { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SenderFullName { get; set; }
    }
}
