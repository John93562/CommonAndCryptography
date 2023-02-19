namespace Common.NetStandard.Models
{
    public class JwtResponse
    {
        public JwtResponse(string token)
        {
            Token = token;
        }

        public string Token { get; set; }


    }
}
