using System.Collections.Generic;

namespace Common.NetStandard.Models.LicenseModel
{
    public class IndianProgram : DomainObject
    {
        public IndianProgram() : base(0)
        {

        }
        public IndianProgram(string name, ICollection<ProgramVersion> allVersions, int id, string imagePath) : base(id)
        {
            Name = name;
            AllVersions = allVersions;
            ImagePath = imagePath;
        }

        public string Name { get; set; }
        public string ImagePath { get; set; }
        public ICollection<ProgramVersion>? AllVersions { get; set; }

    }
}
