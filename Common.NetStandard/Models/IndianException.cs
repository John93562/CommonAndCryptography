using System;
using System.Runtime.Serialization;

namespace Common.NetStandard.Models
{
    public class IndianException : Exception
    {
        public DateTime TimeThatHappened { get; set; }
        public string CurrentAction { get; set; }
        public string IndianStackTrace { get; set; }

        public IndianException()
        {

        }

        public IndianException(DateTime timeThatHappened, string currentAction, string IndianStackTrace)
        {
            TimeThatHappened = timeThatHappened;
            CurrentAction = currentAction;
            this.IndianStackTrace = IndianStackTrace;
        }

        public IndianException(string message, DateTime timeThatHappened, string currentAction, string IndianStackTrace) : base(message)
        {
            TimeThatHappened = timeThatHappened;
            CurrentAction = currentAction;
            this.IndianStackTrace = IndianStackTrace;
        }



        public IndianException(string message, Exception innerException, DateTime timeThatHappened, string currentAction, string IndianStackTrace) : base(message, innerException)
        {
            TimeThatHappened = timeThatHappened;
            CurrentAction = currentAction;
            this.IndianStackTrace = IndianStackTrace;
        }

        protected IndianException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
