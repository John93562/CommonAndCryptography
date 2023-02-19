using System;

namespace Common.NetStandard.Models
{
    public class ChatLog
    {
        public ChatLog(DateTime time, string message, WhoseChatIsIt whoseChatIsIt)
        {
            Time = time;
            Message = message;
            WhoseChatIsIt = whoseChatIsIt;
        }

        public DateTime Time { get; set; }
        public string Message { get; set; }
        public WhoseChatIsIt WhoseChatIsIt { get; set; }

    }
}
