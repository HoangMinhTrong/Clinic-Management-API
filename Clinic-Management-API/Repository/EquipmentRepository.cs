using Clinic_Management_API.Models;
using Clinic_Management_API.Repository.IRepository;

namespace Clinic_Management_API.Repository
{
    public class EquipmentRepository : Repository<Equipment>, IEquipmentRepository
    {
        private readonly ClinicDbContext _db;
        public EquipmentRepository(ClinicDbContext db) : base(db)
        {
            _db = db;
        }
    }
}