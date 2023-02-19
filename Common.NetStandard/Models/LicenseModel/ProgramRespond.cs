namespace Common.NetStandard.Models.LicenseModel
{
    public class ProgramRespond
    {
        public ProgramRespond(ProgramInfoDBO currentProgram, bool hasProgram = true)
        {
            CurrentProgram = currentProgram;
            HasProgram = hasProgram;
        }

        public ProgramInfoDBO CurrentProgram { get; set; }
        public bool HasProgram { get; set; }


    }


}
