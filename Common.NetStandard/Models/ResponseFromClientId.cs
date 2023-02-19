namespace Common.NetStandard.Models
{
    public class ResponseFromClientId
    {
        public ResponseFromClientId(int responseId)
        {
            ResponseId = responseId;
        }

        public int ResponseId { get; set; }
    }
}
