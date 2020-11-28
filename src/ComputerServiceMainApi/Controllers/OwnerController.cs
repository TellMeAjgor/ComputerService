using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerServiceMainApi.Reporitories.OwnerRepositories;
using ComputerServiceMainApi.Services.OwnerServices;
using ComputerServiceModels.Models.Informations;
using Microsoft.AspNetCore.Mvc;

namespace ComputerServiceMainApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {
        private readonly IOwnerService _service;

        public OwnerController(IOwnerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddOwner(OwnerInformation ownerInformation)
        {
            await _service.AddOwner(ownerInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetOwners()
        {
            var owners = await _service.GetOwners();
            return Ok(owners);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOwner(int id)
        {
            var owner = await _service.GetOwner(id);
            return Ok(owner);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOwner(OwnerInformation ownerInformation)
        {
            await _service.UpdateOwner(ownerInformation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOwner(int id)
        {
            await _service.DeleteOwner(id);
            return Ok();
        }
    }
}
