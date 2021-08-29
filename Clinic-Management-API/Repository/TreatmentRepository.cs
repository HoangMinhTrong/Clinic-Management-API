using Clinic_Management_API.Models;
using Clinic_Management_API.Repository.IRepository;

namespace Clinic_Management_API.Repository
{
    public class TreatmentRepository : Repository<Treatment>, ITreatmentRepository
    {
        private readonly ClinicDbContext _db;
        public TreatmentRepository(ClinicDbContext db) : base(db)
        {
            _db = db;
        }
    }
}