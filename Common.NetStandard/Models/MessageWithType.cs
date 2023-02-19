using Common.NetStandard.Interfaces;
using System;

namespace Common.NetStandard.Models
{
    public class MessageWithType
    {
        public MessageWithType(MessageType messageType, IMessageForIndianSupport indianMessage, string title, DateTime date, MessageStatus messageStatus)
        {
            MessageType = messageType;
            IndianMessage = indianMessage;


            MessageTypeText = messageType switch
            {
                MessageType.ProblemMessage => "Πρόβλημα",
                MessageType.IdeaMessage => "Ιδέα",
                MessageType.GeneralMessage => "Chat",
                _ => "??"
            };
            Title = title;
            Date = date;
            MessageStatus = messageStatus;
        }



        public MessageStatus MessageStatus { get; set; }

        public int Id => IndianMessage.Id;

        public MessageType MessageType { get; set; }
        public IMessageForIndianSupport IndianMessage { get; set; }

        public string Title { get; set; }
        public DateTime Date { get; set; }

        public string MessageTypeText { get; set; }

    }
}
