using Common.NetStandard.Models.LicenseModel;

namespace Common.NetStandard.Models
{

    public class CreateSomethingIDontKnowDude
    {
        public CreateSomethingIDontKnowDude()
        {

        }
        public CreateSomethingIDontKnowDude(CreateNewUserSimplifiedResponse value)
        {
            Value = value;
        }

        public CreateNewUserSimplifiedResponse Value { get; set; }
    }
}