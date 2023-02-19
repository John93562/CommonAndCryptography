using System.ComponentModel.DataAnnotations;

namespace Common.NetStandard.Models.LicenseModel
{


    public class AdminRegisterOneTime
    {
        public AdminRegisterOneTime(string username, string name)
        {
            Username = username;
            Name = name;
        }

        [Required]
        public string Username { get; set; }
        public string Name { get; set; }



    }
}
