using System.Collections.Generic;
using AutoMapper;
using Clinic_Management_API.Models;
using Clinic_Management_API.Models.DTOs;
using Clinic_Management_API.Repository;
using Clinic_Management_API.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Clinic_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckUpController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CheckUpController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult GetCheckUp()
        {
            var objList = _unitOfWork.CheckUp.GetAll();
            var objDto = new List<CheckUpDTOs>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<CheckUpDTOs>(obj));
            }
            return Ok(objDto);
        }

        [HttpGet("{checkupid:int}")]
        public IActionResult GetCheckUp(int checkupid)
        {
            var obj = _unitOfWork.CheckUp.GetById(checkupid);
            if (obj == null)
            {
                return NotFound();
            }

            var objDto = _mapper.Map<CheckUpDTOs>(obj);
            return Ok(objDto);
        }

        [HttpPost]
        public IActionResult CreateCheckUp([FromBody] CheckUpDTOs checkUpDtOs)
        {
            if (checkUpDtOs == null)
            {
                return BadRequest(ModelState);
            }

            if (_unitOfWork.CheckUp.Exist(checkUpDtOs.Id))
            {
                ModelState.AddModelError("","The Checkup is already Exist!");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var objDto = _mapper.Map<CheckUp>(checkUpDtOs);
            if (!_unitOfWork.CheckUp.AddTypeBool(objDto))
            {
                ModelState.AddModelError("",$"Something wrong when save the record {objDto.Id}");
                return StatusCode(500, ModelState);
            }

            return CreatedAtRoute("CreateCheckUp", new {checkupid = objDto.Id}, checkUpDtOs);
        }

        [HttpPatch("{checkupid:int}")]
        public IActionResult UpdateCheckUp(int checkupid, [FromBody] CheckUpDTOs checkUpDtOs )
        {
            if (checkUpDtOs == null || checkupid != checkUpDtOs.Id)
            {
                return BadRequest(ModelState);
            }

            var objDto = _mapper.Map<CheckUp>(checkUpDtOs);
            if (!_unitOfWork.CheckUp.UpdateTypeBool(objDto))
            {
                ModelState.AddModelError("",$"Something wrong when update the record {objDto.Id}");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{checkupid:int}")]
        public IActionResult DeleteCheckUp(int checkupid)
        {
            if (!_unitOfWork.CheckUp.Exist(checkupid))
            {
                return NotFound();
            }

            var objDto = _unitOfWork.CheckUp.GetById(checkupid);
            if (!_unitOfWork.CheckUp.DeleteTypeBool(objDto))
            {
                ModelState.AddModelError("",$"Something wrong when delete the record {objDto.Id}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }
    }
}