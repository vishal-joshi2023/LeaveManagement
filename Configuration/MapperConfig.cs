
using AutoMapper;
using LeaveManagement.Data;
using LeaveManagement.Models;

namespace LeaveManagement.Configuration
{
   public class MapperConfig : Profile
    {
       public MapperConfig() {

            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}