namespace Common.NetStandard.Models
{
    public class DeleteResponse
    {
        public DeleteResponse(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
}