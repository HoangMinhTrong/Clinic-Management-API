using AutoMapper;
using Clinic_Management_API.Repository;
using Clinic_Management_API.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Clinic_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckUpControllers : Controller
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CheckUpControllers(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult GetCheckUp()
        {
            var objList = _unitOfWork.CheckUp.GetAll();
            return Ok(objList);
        }
        
    }
}