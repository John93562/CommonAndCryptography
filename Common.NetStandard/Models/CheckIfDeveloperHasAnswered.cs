namespace Common.NetStandard.Models
{
    public class CheckIfDeveloperHasAnswered
    {
        public CheckIfDeveloperHasAnswered(bool hasAnswered)
        {
            HasAnswered = hasAnswered;
        }

        public bool HasAnswered { get; set; }
    }

}
