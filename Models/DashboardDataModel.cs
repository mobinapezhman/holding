using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace WebApplication1.Models
{
    public class DashboardDataModel
    {

        public int CompanyId { get; set; }
        public string? CompanyTitle { get; set; }
        public int ParentId { get; set; }
        public string? UnitTitle { get; set; }
        public int UnitParentId { get; set; }
        public int KpiGroupId { get; set; }
        public string? KpiGroupTitle { get; set; }
        public string? DimDatePersianDate { get; set; }
        public long KpiGroupScore { get; set; }


    }
}
