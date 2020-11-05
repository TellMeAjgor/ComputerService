using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComputerServiceMainApi.Data;
using ComputerServiceModels.Models.Entities;
using ComputerServiceModels.Models.Informations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<OwnerInformation>> GetOwners()
        {
            var owners = await _context.Owners.ToListAsync();
            return _mapper.Map<IEnumerable<OwnerInformation>>(owners);
        }

        public async Task<OwnerInformation> GetOwner(int id)
        {
            var owner = await _context.Owners.
                FirstOrDefaultAsync(x => x.OwnerId == id);
            return _mapper.Map<OwnerInformation>(owner);
        }
    }
}
