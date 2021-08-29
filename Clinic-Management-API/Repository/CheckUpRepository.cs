using Clinic_Management_API.Models;
using Clinic_Management_API.Repository.IRepository;

namespace Clinic_Management_API.Repository
{
    public class CheckUpRepository : Repository<CheckUp>, ICheckUpRepository
    {
        private readonly ClinicDbContext _db;
        public CheckUpRepository(ClinicDbContext db) : base(db)
        {
            _db = db;
        }
    }
}