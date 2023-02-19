namespace Common.NetStandard.Models
{
    public class AttachmentSimplified
    {
        public AttachmentSimplified(string path, string fileName)
        {
            FilePath = path;
            FileName = fileName;
        }

        public string FilePath { get; set; }
        public string FileName { get; set; }
    }
}
