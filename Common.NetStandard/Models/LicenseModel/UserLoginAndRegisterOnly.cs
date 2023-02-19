using System.ComponentModel.DataAnnotations;

namespace Common.NetStandard.Models.LicenseModel
{
    public class ProgramInfoResponseForId
    {
        public ProgramInfoResponseForId()
        {

        }
        public ProgramInfoResponseForId(int programInfoId)
        {
            ProgramInfoId = programInfoId;
        }

        public int ProgramInfoId { get; set; }
    }

    public class UserLoginAndRegisterOnly
    {
        public UserLoginAndRegisterOnly()
        {

        }
        public UserLoginAndRegisterOnly(string username, string password, string name)
        {
            Username = username;
            Password = password;
            Name = name;
        }

        [Required]
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
