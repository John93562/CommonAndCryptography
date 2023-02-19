using Common.NetStandard.Models.LicenseModel;

namespace Common.NetStandard.Models
{
    public class MessageResponse
    {
        public MessageResponse()
        {

        }
        public MessageResponse(IndianMessage message)
        {
            Message = message;
        }

        public IndianMessage Message { get; set; }

    }
}
