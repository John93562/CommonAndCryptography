namespace Common.NetStandard.Models
{

    public class BoolWithIdResponse
    {
        public BoolWithIdResponse(bool success, int id)
        {
            Success = success;
            Id = id;
        }

        public bool Success { get; set; }
        public int Id { get; set; }
    }
}
