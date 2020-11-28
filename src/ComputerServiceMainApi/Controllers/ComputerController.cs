using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerServiceMainApi.Services.ComputerServices;
using ComputerServiceModels.Models.Informations;
using Microsoft.AspNetCore.Mvc;

namespace ComputerServiceMainApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputerController : Controller
    {
        private readonly IComputerService _service;

        public ComputerController(IComputerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddComputer(ComputerInformation computerInformation)
        {
            await _service.AddComputer(computerInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetComputers()
        {
            var computers = await _service.GetComputers();
            return Ok(computers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetComputer(int id)
        {
            var computer = await _service.GetComputer(id);
            return Ok(computer);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComputer(ComputerInformation computerInformation)
        {
            await _service.UpdateComputer(computerInformation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComputer(int id)
        {
            await _service.DeleteComputer(id);
            return Ok();
        }
    }
}
