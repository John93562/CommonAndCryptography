namespace Common.NetStandard.Models
{
    public class DomainObject
    {
        //public DomainObject()
        //{

        //}
        public DomainObject(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
