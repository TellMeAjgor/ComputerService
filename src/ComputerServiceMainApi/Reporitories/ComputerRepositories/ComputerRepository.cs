using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using ComputerServiceMainApi.Data;
using ComputerServiceModels.Models.Entities;
using ComputerServiceModels.Models.Informations;
using Microsoft.EntityFrameworkCore;

namespace ComputerServiceMainApi.Reporitories.ComputerRepositories
{
    public class ComputerRepository : IComputerRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ComputerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddComputer(ComputerInformation computerInformation)
        {
            var computer = _mapper.Map<Computer>(computerInformation);
            await _context.Computers.AddAsync(computer);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ComputerInformation>> GetComputers()
        {
            var computers = await _context.Computers.ToListAsync();
            return _mapper.Map<IEnumerable<ComputerInformation>>(computers);
        }

        public async Task<ComputerInformation> GetComputer(int id)
        {
            var computer = await _context.Computers.FirstOrDefaultAsync(x => x.ComputerId == id);
            return _mapper.Map<ComputerInformation>(computer);
        }
    }
}
