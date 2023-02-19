using System;

namespace Common.NetStandard.Models.LicenseModel
{
    public class HealthCheck : DomainObject
    {
        public HealthCheck() : base(0)
        {

        }
        public HealthCheck(bool success, DateTime date, string exceptions, int id, ProgramInfo ownerProgram) : base(id)
        {
            Success = success;
            Date = date;
            Exceptions = exceptions;
            OwnerProgram = ownerProgram;
        }

        public bool Success { get; set; }
        public DateTime Date { get; set; }

        public string Exceptions { get; set; }

        public ProgramInfo? OwnerProgram { get; set; }

    }


}
