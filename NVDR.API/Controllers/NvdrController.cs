using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NVDR.API.Controllers
{
    [Route("api/nvdr")]
    [ApiController]
    public class NvdrController : ControllerBase
    {

        private ILoggerManager _logger;
        private readonly IRepositoryManager _repository;

        public NvdrController(ILoggerManager logger, IRepositoryManager repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetNvdrRecords()
        {
            try
            {

                var nvdrRecords = _repository.NvdrRecordRepository.GetAllNvdrRecord(trackChanges: false);
                return Ok(nvdrRecords);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error"+ex.Message);
            }
        }

        [HttpGet("getNvdrRecord/{id}")]
        public IActionResult GetNvdrRecord(long id)
        {
            try
            {

                var nvdrRecords = _repository.NvdrRecordRepository.GetNvdrRecord(id,trackChanges: false);
                return Ok(nvdrRecords);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddNvdr(NvdrRecord nvdrRecord)
        {
            try
            {
                if (nvdrRecord == null)
                {
                    return StatusCode(500, "Model is Null");
                }
                if (ModelState.IsValid)
                {
                    _repository.NvdrRecordRepository.AddNvdrRecord(nvdrRecord);
                    _repository.Save();

                }
                return Ok(nvdrRecord);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }


         [HttpPut]
         public IActionResult UpdateNvdr(NvdrRecord nvdrRecord)
        {
            try
            {
                if (nvdrRecord == null)
                {
                    return StatusCode(500, "Model is Null");
                }
                if (ModelState.IsValid)
                {                    
                     _repository.NvdrRecordRepository.UpdateNvdrRecord(nvdrRecord);
          
                    _repository.Save();

                }
                return Ok(nvdrRecord);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }
        
        
        [HttpDelete]
         public IActionResult DeleteNvdr(NvdrRecord nvdrRecord)
        {
            try
            {
                if (nvdrRecord == null)
                {
                    return StatusCode(500, "Model is Null");
                }
                if (ModelState.IsValid)
                {                    
                     _repository.NvdrRecordRepository.DeleteNvdrRecord(nvdrRecord);
          
                    _repository.Save();

                }
                return Ok(nvdrRecord);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }

       


    }
}