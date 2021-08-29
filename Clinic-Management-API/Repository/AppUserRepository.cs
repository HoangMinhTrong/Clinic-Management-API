using Clinic_Management_API.Models;
using Clinic_Management_API.Repository.IRepository;

namespace Clinic_Management_API.Repository
{
    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        private readonly ClinicDbContext _db;
        public AppUserRepository(ClinicDbContext db) : base(db)
        {
            _db = db;
        }
    }
}