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

        [HttpPost("Upsert")]
        public IActionResult UpsertNvdrRecords(NvdrRecord nvdrRecords)
        {
            try
            {
                if (nvdrRecords == null)
                {
                    return StatusCode(500, "Model is Null");
                }
                if (ModelState.IsValid)
                {
                    if (nvdrRecords.Id == 0)
                    {
                        _repository.NvdrRecordRepository.AddNvdrRecord(nvdrRecords);
                    }
                    else
                    {
                        _repository.NvdrRecordRepository.UpdateNvdrRecord(nvdrRecords);
                    }
                    _repository.Save();

                }
                return Ok(nvdrRecords);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }




    }
}