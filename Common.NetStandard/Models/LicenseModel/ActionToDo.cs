using System;

namespace Common.NetStandard.Models.LicenseModel
{

    public class ActionToDo : DomainObject
    {

        public ActionToDo() : base(0)
        {

        }


        public ActionToDo(ActionStatus status, ActionToPerform actionToPerform, string affectedFullName, DateTime date, ProgramInfo program, int id, string passwordToBeChanged) : base(id)
        {
            Status = status;
            ActionToPerform = actionToPerform;
            AffectedFullName = affectedFullName;
            Date = date;
            ProgramInfo = program;
            PasswordToBeChanged = passwordToBeChanged;
        }

        public ActionStatus Status { get; set; }
        public ActionToPerform ActionToPerform { get; set; }
        public string AffectedFullName { get; set; }
        public ProgramInfo? ProgramInfo { get; set; }
        public DateTime Date { get; set; }
        public string PasswordToBeChanged { get; set; }
    }


}
