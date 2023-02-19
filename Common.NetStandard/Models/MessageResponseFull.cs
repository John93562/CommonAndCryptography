using System;

namespace Common.NetStandard.Models
{
    public class MessageResponseFull
    {
        public MessageResponseFull(MessageType messageType, string title, string fullName, DateTime date)
        {
            MessageType = messageType;
            Title = title;
            FullName = fullName;
            Date = date;
        }

        public MessageType MessageType { get; set; }
        public string Title { get; set; }
        public string FullName { get; set; }
        public DateTime Date { get; }
    }



}
