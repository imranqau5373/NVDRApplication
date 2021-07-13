using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
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





    }
}