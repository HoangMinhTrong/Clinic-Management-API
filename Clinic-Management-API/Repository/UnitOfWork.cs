using System.Threading.Tasks;
using Clinic_Management_API.Models;
using Clinic_Management_API.Repository.IRepository;

namespace Clinic_Management_API.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClinicDbContext _db;
        public IAppUserRepository AppUser { get; private set; }
        public ICheckUpRepository CheckUp { get; private set; }
        public IEquipmentRepository Equipment { get; private set; }
        public ITreatmentRepository Treatment { get; private set; }
        public UnitOfWork(ClinicDbContext db)
        {
            _db = db;
            AppUser = new AppUserRepository(_db);
            CheckUp = new CheckUpRepository(_db);
            Equipment = new EquipmentRepository(_db);
            Treatment = new TreatmentRepository(_db);

        }
        public void SaveChange()
        {
            _db.SaveChanges();
        }

        public async Task SaveChangeAsync()
        {
            await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}