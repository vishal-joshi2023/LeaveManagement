using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }


        [Display(Name = "Leave Type Name")] //annotation for DefaultDays
        [Required]                          // req field  
        public string Name { get; set; }
        

        [Display(Name = "Default Number Of Days")] //annotation for DefaultDays
        [Required]
        [Range(1, 25, ErrorMessage ="Enter Valid A Number")] //restrict user for valid ip
        public int DefaultDays { get; set; }
    }
}
