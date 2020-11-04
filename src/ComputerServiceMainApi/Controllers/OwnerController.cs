using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerServiceMainApi.Reporitories.OwnerRepositories;
using ComputerServiceModels.Models.Informations;
using Microsoft.AspNetCore.Mvc;

namespace ComputerServiceMainApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {
        private readonly IOwnerRepository _repository;

        public OwnerController(IOwnerRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> AddOwner(OwnerInformation ownerInformation)
        {
            await _repository.AddOwner(ownerInformation);
            return Ok();
        }
    }
}
