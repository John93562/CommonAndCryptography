using System.Collections.Generic;

namespace Common.NetStandard.Models.LicenseModel
{
    public class ActionsResponse
    {
        public ActionsResponse()
        {

        }
        public ActionsResponse(List<ActionResponseModel> actionsThatWereCompleted, string username)
        {
            ActionsThatWereCompleted = actionsThatWereCompleted;
            Username = username;
        }

        public List<ActionResponseModel> ActionsThatWereCompleted { get; set; }

        public string Username { get; set; }

    }
}
