using Common.NetStandard.Models.LicenseModel;

namespace Common.NetStandard.Models
{
    public class ProgramVersionModel
    {
        public ProgramVersionModel(string programVersion, string programBase, string key, int programInfoId, LicenseType licenseType, LicenseStatus licenseStatus, string name)
        {
            ProgramVersion = programVersion;
            ProgramBase = programBase;
            Key = key;
            ProgramInfoId = programInfoId;
            LicenseType = licenseType;
            LicenseStatus = licenseStatus;
            Name = name;
        }
        public LicenseType LicenseType { get; set; }
        public LicenseStatus LicenseStatus { get; set; }
        public string ProgramVersion { get; set; }
        public string Name { get; set; }
        public string ProgramBase { get; set; }
        public string Key { get; set; }
        public int ProgramInfoId { get; set; }

    }
}
