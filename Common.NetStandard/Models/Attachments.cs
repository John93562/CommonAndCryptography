namespace Common.NetStandard.Models
{
    public class Attachments : DomainObject
    {
        public Attachments() : base(0)
        {

        }

        public Attachments(string attachmentName, string attachmentPath, int id) : base(id)
        {
            AttachmentName = attachmentName;
            AttachmentPath = attachmentPath;
        }

        public string AttachmentName { get; set; }
        public string AttachmentPath { get; set; }
    }


}
