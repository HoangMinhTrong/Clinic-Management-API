using Clinic_Management_API.Models;

namespace Clinic_Management_API.Repository.IRepository
{
    public interface ICheckUpRepository : IRepository<CheckUp>
    {
        public bool Exist(string id);
        public bool Exist(int id);
 
    }
}