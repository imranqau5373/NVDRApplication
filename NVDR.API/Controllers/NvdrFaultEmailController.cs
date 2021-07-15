using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NVDR.API.Controllers
{

    [Route("api/nvdrFaultEmail")]
    [ApiController]
    public class NvdrFaultEmailController : ControllerBase
    {

        private ILoggerManager _logger;
        private readonly IRepositoryManager _repository;

        public NvdrFaultEmailController(ILoggerManager logger, IRepositoryManager repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetNvdrFaultEmails()
        {
            try
            {

                var nvdrRecords = _repository.NvdrFaultEmailRepository.GetAllNvdrFaultEmail(trackChanges: false);
                return Ok(nvdrRecords);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddNvdrFaultEmail(NvdrFaultEmail nvdrFaultEmail)
        {
            try
            {
                if (nvdrFaultEmail == null)
                {
                    return StatusCode(500, "Model is Null");
                }
                if (ModelState.IsValid)
                {

                    _repository.NvdrFaultEmailRepository.AddNvdrFaultEmail(nvdrFaultEmail);



                    _repository.Save();

                }
                return Ok(nvdrFaultEmail);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }


        [HttpPut]
        public IActionResult UpdateNvdr(NvdrFaultEmail nvdrFaultEmail)
        {
            try
            {
                if (nvdrFaultEmail == null)
                {
                    return StatusCode(500, "Model is Null");
                }
                if (ModelState.IsValid)
                {
                    _repository.NvdrFaultEmailRepository.UpdateNvdrFaultEmail(nvdrFaultEmail);

                    _repository.Save();

                }
                return Ok(nvdrFaultEmail);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }


        [HttpDelete]
        public IActionResult DeleteNvdr(NvdrFaultEmail nvdrFaultEmail)
        {
            try
            {
                if (nvdrFaultEmail == null)
                {
                    return StatusCode(500, "Model is Null");
                }
                if (ModelState.IsValid)
                {
                    _repository.NvdrFaultEmailRepository.DeleteNvdrFaultEmail(nvdrFaultEmail);

                    _repository.Save();

                }
                return Ok(nvdrFaultEmail);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }
    }
}
