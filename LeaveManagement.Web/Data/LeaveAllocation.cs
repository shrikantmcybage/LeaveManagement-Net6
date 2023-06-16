using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    { 
        public int NumberOfDays { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; } 
        public int LeaveTypeId { get; set; }

        public String EmployeeId { get; set; }

    }
}
