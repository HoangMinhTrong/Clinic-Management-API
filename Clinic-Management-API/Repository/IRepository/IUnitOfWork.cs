using System;
using System.Threading.Tasks;

namespace Clinic_Management_API.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IAppUserRepository AppUser { get; }
        ICheckUpRepository CheckUp { get; }
        IEquipmentRepository Equipment { get; }
        ITreatmentRepository Treatment { get; }
        void SaveChange();
        Task SaveChangeAsync();
    }
}