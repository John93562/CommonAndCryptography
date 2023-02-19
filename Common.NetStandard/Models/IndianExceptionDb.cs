using System;

namespace Common.NetStandard.Models
{
    public class IndianExceptionDb
    {
        public IndianExceptionDb(int id, string currentAction, DateTime date, string indianStackTrace, string title, IndianExceptionDb innerException = null)
        {
            Id = id;
            CurrentAction = currentAction;
            Date = date;
            IndianStackTrace = indianStackTrace;
            InnerException = innerException;
            Title = title;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string CurrentAction { get; set; }
        public DateTime Date { get; set; }
        public string IndianStackTrace { get; set; }
        public IndianExceptionDb InnerException { get; set; }
    }
}
