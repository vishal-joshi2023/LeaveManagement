using LeaveManagement.Data;

namespace LeaveManagement.Configuration.Contracts
{
    //this related to specifically LeaveType  -> specific fun. related to leaveType + basic crud(IGenRepo)
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {

    }
}
