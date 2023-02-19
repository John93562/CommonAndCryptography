namespace Common.NetStandard.Models
{

    public class BoolResponse
    {
        public BoolResponse(bool value)
        {
            Value = value;
        }

        public bool Value { get; set; }
    }
}
