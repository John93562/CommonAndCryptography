using System;

namespace Common.NetStandard.Models
{
    public class HealthCheckDBO
    {
        public HealthCheckDBO(int id, bool success, DateTime date, string exceptions)
        {
            Id = id;
            Success = success;
            Date = date;
            Exceptions = exceptions;
        }

        public int Id { get; set; }
        public bool Success { get; set; }
        public DateTime Date { get; set; }

        public string Exceptions { get; set; }
    }
}
