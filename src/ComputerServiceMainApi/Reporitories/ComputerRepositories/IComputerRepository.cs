﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerServiceModels.Models.Informations;

namespace ComputerServiceMainApi.Reporitories.ComputerRepositories
{
    public interface IComputerRepository
    {
        Task AddComputer(ComputerInformation computerInformation);
        Task<IEnumerable<ComputerInformation>> GetComputers();
        Task<ComputerInformation> GetComputer(int id);
        Task UpdateComputer(ComputerInformation computerInformation);
        Task DeleteComputer(int id);
    }
}
