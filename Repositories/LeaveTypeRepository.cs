using LeaveManagement.Configuration.Contracts;
using LeaveManagement.Data;

namespace LeaveManagement.Repositories
{
    //It takes preImplemeted from GenericRepo : And implements IleaveTypeRepo
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        // copy of DB context comes from GenericRepo
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
