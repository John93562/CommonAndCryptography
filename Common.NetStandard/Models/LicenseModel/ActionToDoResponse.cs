namespace Common.NetStandard.Models.LicenseModel
{
    public class ActionToDoResponse
    {
        public ActionToDoResponse(ActionToDo actionToDo)
        {
            ActionToDo = actionToDo;
        }

        public ActionToDo ActionToDo { get; set; }
    }
}
