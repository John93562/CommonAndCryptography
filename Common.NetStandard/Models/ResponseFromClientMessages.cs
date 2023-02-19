using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class ResponseFromClientMessages
    {
        public ResponseFromClientMessages(List<MessageExtended> messages)
        {
            Messages = messages;
        }

        public List<MessageExtended> Messages { get; set; }
    }
}
