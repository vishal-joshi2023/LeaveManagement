namespace LeaveManagement.Data
{
    public abstract class BaseEntity
    {
        int Id { get; set; }

        DateTime DateCreated { get; set; }

        DateTime DateModified { get; set; }
    }
}
