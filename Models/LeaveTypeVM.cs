using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        [Display(Name = "Default Number Of Days")] //annotation for DefaultDays
        public int DefaultDays { get; set; }
    }
}
