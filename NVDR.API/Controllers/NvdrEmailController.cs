using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NVDR.API.Controllers
{

    [Route("api/nvdrEmail")]
    [ApiController]
    public class NvdrEmailController : ControllerBase
    {

        private ILoggerManager _logger;
        private readonly IRepositoryManager _repository;

        public NvdrEmailController(ILoggerManager logger, IRepositoryManager repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetNvdrEmails()
        {
            try
            {

                var nvdrRecords = _repository.NvdrEmailRepository.GetAllNvdrEmail(trackChanges: false);
                return Ok(nvdrRecords);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddNvdrEmail(NvdrEmail nvdrEmail)
        {
            try
            {
                if (nvdrEmail == null)
                {
                    return StatusCode(500, "Model is Null");
                }
                if (ModelState.IsValid)
                {

                    _repository.NvdrEmailRepository.AddNvdrEmail(nvdrEmail);



                    _repository.Save();

                }
                return Ok(nvdrEmail);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }


        [HttpPut]
        public IActionResult UpdateNvdr(NvdrEmail nvdrEmail)
        {
            try
            {
                if (nvdrEmail == null)
                {
                    return StatusCode(500, "Model is Null");
                }
                if (ModelState.IsValid)
                {
                    _repository.NvdrEmailRepository.UpdateNvdrEmail(nvdrEmail);

                    _repository.Save();

                }
                return Ok(nvdrEmail);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }


        [HttpDelete]
        public IActionResult DeleteNvdr(NvdrEmail nvdrEmail)
        {
            try
            {
                if (nvdrEmail == null)
                {
                    return StatusCode(500, "Model is Null");
                }
                if (ModelState.IsValid)
                {
                    _repository.NvdrEmailRepository.DeleteNvdrEmail(nvdrEmail);

                    _repository.Save();

                }
                return Ok(nvdrEmail);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }
    }
}
