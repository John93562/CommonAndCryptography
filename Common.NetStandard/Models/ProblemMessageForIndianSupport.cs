using Common.NetStandard.Interfaces;
using System;
using System.Collections.Generic;

namespace Common.NetStandard.Models
{

    public class ProblemMessageForIndianSupport : IMessageForIndianSupport
    {
        public ProblemMessageForIndianSupport(int id = 0, MessageStatus status = MessageStatus.NotReportedYet,
            string title = "",
            string problemDescription = "",
            string senderFullName = "",
            string howItHappened = "",
            string developerAnswer = "")
        {
            Id = id;
            AllExceptions = new List<IndianExceptionDb>();
            Status = status;
            Title = title;
            Description = problemDescription;
            SenderFullName = senderFullName;
            HowItHappened = howItHappened;
            DeveloperAnswer = developerAnswer;
        }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public List<IndianExceptionDb> AllExceptions { get; set; }
        public MessageStatus Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SenderFullName { get; set; }
        public string HowItHappened { get; set; }
        public string DeveloperAnswer { get; set; }
    }
}
