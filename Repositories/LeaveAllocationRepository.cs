using LeaveManagement.Configuration.Contracts;
using LeaveManagement.Configuration.StringsRoles;
using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly UserManager<Employee> userManager;
        
        private readonly ILeaveTypeRepository leaveTypeRepository;

        private readonly ApplicationDbContext context;

       public LeaveAllocationRepository (ApplicationDbContext context , UserManager<Employee>  userManager 
              ,ILeaveTypeRepository leaveTypeRepository) : base(context)
        {
            // context need for checking Leave already exists or not
            this.context = context;

            // Users in Roles gets leave by Admin
            this.userManager = userManager;

            this.leaveTypeRepository = leaveTypeRepository;

        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            // q -> Sql query
            return await context.LeaveAllocations.AnyAsync(
                q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId && q.Period == period);
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Role.User);
            
            var period = DateTime.Now.Year;
            
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);

            var allocations = new List<LeaveAllocation>();
            
            foreach(var employee in employees)
            {
                /* add ony by one
                var allocation = new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveType.Id,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                };

                await AddAsync(allocation); //define in GenericRepo
                */


                // check if already emp having leave of not 

                if (! await AllocationExists(employee.Id, leaveTypeId, period))
                {
                    // Add all at ones

                    allocations.Add(new LeaveAllocation
                    {
                        EmployeeId = employee.Id,
                        LeaveTypeId = leaveTypeId,
                        Period = period,
                        NumberOfDays = leaveType.DefaultDays
                    });
                }
                 
            }

            await AddRangeAsync(allocations); // all entire list at ones

           
        }
    }
}
