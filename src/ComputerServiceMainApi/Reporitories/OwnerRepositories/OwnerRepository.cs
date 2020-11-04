using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComputerServiceMainApi.Data;
using ComputerServiceModels.Models.Entities;
using ComputerServiceModels.Models.Informations;
using Microsoft.AspNetCore.Mvc;

namespace ComputerServiceMainApi.Reporitories.OwnerRepositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public OwnerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddOwner(OwnerInformation ownerInformation)
        {
            var owner = _mapper.Map<Owner>(ownerInformation);
            await _context.Owners.AddAsync(owner);

            await _context.SaveChangesAsync();
        }
    }
}
