using System;

namespace Common.NetStandard.Models.LicenseModel
{
    public class ActionToDoDBO
    {
        public ActionToDoDBO(ActionStatus status, ActionToPerform actionToPerform, string affectedFullName, int programId, DateTime date, string passwordToBeChanged, int id, string programName, string username)
        {
            Status = status;
            ActionToPerform = actionToPerform;
            AffectedFullName = affectedFullName;
            ProgramId = programId;
            Date = date;
            PasswordToBeChanged = passwordToBeChanged;
            Id = id;
            ProgramName = programName;
            Username = username;
        }
        public int Id { get; set; }
        public ActionStatus Status { get; set; }
        public ActionToPerform ActionToPerform { get; set; }
        public string AffectedFullName { get; set; }
        public int ProgramId { get; set; }
        public DateTime Date { get; set; }
        public string PasswordToBeChanged { get; set; }
        public string ProgramName { get; set; }
        public string Username { get; set; }

    }


}
