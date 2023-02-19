using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class AllMessagesResponse
    {
        public AllMessagesResponse(IEnumerable<IndianMessageDBO> allMessages)
        {
            AllMessages = allMessages;
        }

        public IEnumerable<IndianMessageDBO> AllMessages { get; set; }
    }
}
