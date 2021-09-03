using System.Linq;
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

        public bool Exist(string id)
        {
            bool value = _db.CheckUps.Any(a => a.user_id.ToLower().Trim() == id.ToLower().Trim());
            return value;
        }

        public bool Exist(int id)
        {
            return _db.CheckUps.Any(a => a.Id == id);
        }

        

  
    }
}