namespace Common.NetStandard.Models
{
    public class FullLicenseDBO
    {
        public FullLicenseDBO(ProgramInfoDBOFull programInfoDBO, IndianLicenseDBO indianLicenseDBO, int id, string username, string nameOfUser)
        {
            ProgramInfoDBO = programInfoDBO;
            IndianLicenseDBO = indianLicenseDBO;
            Id = id;
            Username = username;
            NameOfUser = nameOfUser;
        }
        public int Id { get; set; }
        public string NameOfUser { get; set; }
        public string Username { get; set; }
        public ProgramInfoDBOFull ProgramInfoDBO { get; set; }
        public IndianLicenseDBO IndianLicenseDBO { get; set; }
    }
}
