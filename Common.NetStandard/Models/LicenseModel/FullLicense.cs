namespace Common.NetStandard.Models.LicenseModel
{
    public class FullLicense : DomainObject
    {
        public FullLicense() : base(0)
        {

        }
        public FullLicense(ProgramInfo indianProgram, IndianLicense indianLicense, IndianUser owner, int id) : base(id)
        {
            IndianProgram = indianProgram;
            IndianLicense = indianLicense;
            Owner = owner;
        }
        public ProgramInfo? IndianProgram { get; set; }
        public IndianLicense? IndianLicense { get; set; }

        public IndianUser? Owner { get; set; }
    }


}
