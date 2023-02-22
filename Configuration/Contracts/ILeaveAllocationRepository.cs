using LeaveManagement.Data;

namespace LeaveManagement.Configuration.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        // Allocate Leave
        Task LeaveAllocation(int leaveTypeId);

        // Check if leave already allocated or not
        Task<bool> AllocationExists(string employeeId ,int leaveTypeId , int period);
    }
}
