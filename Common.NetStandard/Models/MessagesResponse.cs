using Common.NetStandard.Models.LicenseModel;
using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class MessagesResponse
    {
        public List<IndianMessage> Messages = new List<IndianMessage>();

        public MessagesResponse(List<IndianMessage> messages)
        {
            Messages = messages;
        }
    }
}
