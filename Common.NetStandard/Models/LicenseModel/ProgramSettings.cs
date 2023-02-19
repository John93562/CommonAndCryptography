namespace Common.NetStandard.Models.LicenseModel
{
    public class ProgramSettings
    {
        public ProgramSettings(string pathToSaveBackups, string rootPathToRetrieveTempZipBacAndSaveAssets)
        {
            PathToSaveBackups = pathToSaveBackups;
            RootPathToRetrieveTempZipBacAndSaveAssets = rootPathToRetrieveTempZipBacAndSaveAssets;
        }

        public string PathToSaveBackups { get; set; }
        public string RootPathToRetrieveTempZipBacAndSaveAssets { get; set; }


    }
}
