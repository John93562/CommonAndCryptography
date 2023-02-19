namespace Common.NetStandard.Models
{
    public class UserSimplified
    {
        public UserSimplified(string username, int id)
        {
            Username = username;
            Id = id;
        }

        public string Username { get; set; }
        public int Id { get; set; }

    }
}
