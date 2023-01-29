using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Data
{
    public class LeaveAllocation : BaseEntity
    {
       

        //Foreign key mapping
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }     //Foreign key 

        //Actual allocation
        public string EmployeeId { get; set; }

    }
}
