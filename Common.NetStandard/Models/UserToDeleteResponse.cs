namespace Common.NetStandard.Models
{
    public class UserToDeleteResponse
    {
        public UserToDeleteResponse()
        {

        }
        public UserToDeleteResponse(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
