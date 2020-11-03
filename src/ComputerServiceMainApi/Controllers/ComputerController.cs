using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerServiceMainApi.Reporitories.ComputerRepositories;
using ComputerServiceModels.Models.Informations;
using Microsoft.AspNetCore.Mvc;

namespace ComputerServiceMainApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputerController : Controller
    {
        private readonly IComputerRepository _repository;

        public ComputerController(IComputerRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> AddComputer(ComputerInformation computerInformation)
        {
            await _repository.AddComputer(computerInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetComputers()
        {
            var computers = await _repository.GetComputers();
            return Ok(computers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetComputer(int id)
        {
            var computer = await _repository.GetComputer(id);
            return Ok(computer);
        }
    }
}
