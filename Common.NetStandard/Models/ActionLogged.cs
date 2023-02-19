using System;
using System.Collections.Generic;

namespace Common.NetStandard.Models
{
    public class ActionLogged : DomainObject
    {

        public ActionLogged() : base(0)
        {

        }
        public ActionLogged(ActionEnum action, DateTime timeThatHappened, UserThatWasAffected ownerOfAction, string nameOfAffected,
            int idOfAffected, Email emailThatWasSent, ICollection<Attachments> attachments, ICollection<UserThatWasAffected> customersThatWereAffected, int id) : base(id)
        {
            Action = action;
            TimeThatHappened = timeThatHappened;
            OwnerOfAction = ownerOfAction;
            NameOfAffected = nameOfAffected;
            IdOfAffected = idOfAffected;
            EmailThatWasSent = emailThatWasSent;
            Attachments = attachments;
            CustomersThatWereAffected = customersThatWereAffected;
        }

        public ActionEnum Action { get; set; }

        public DateTime TimeThatHappened { get; set; }

        public UserThatWasAffected? OwnerOfAction { get; set; }

        public string NameOfAffected { get; set; }
        public int IdOfAffected { get; set; }
        public Email? EmailThatWasSent { get; set; }

        public ICollection<Attachments>? Attachments { get; set; }

        public ICollection<UserThatWasAffected>? CustomersThatWereAffected { get; set; }


    }


}
