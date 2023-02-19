using System;

namespace Common.NetStandard.Models.LicenseModel
{
    public class ActionResponseModel
    {
        public ActionResponseModel(int id, bool success, DateTime date)
        {
            Id = id;
            Success = success;
            Date = date;
        }

        public int Id { get; set; }
        public bool Success { get; set; }
        public DateTime Date { get; set; }
    }
}
