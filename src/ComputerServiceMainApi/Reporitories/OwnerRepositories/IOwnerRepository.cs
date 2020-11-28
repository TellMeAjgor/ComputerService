using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerServiceModels.Models.Informations;

namespace ComputerServiceMainApi.Reporitories.OwnerRepositories
{
    public interface IOwnerRepository
    {
        Task AddOwner(OwnerInformation ownerInformation);
        Task<IEnumerable<OwnerInformation>> GetOwners();
        Task<OwnerInformation> GetOwner(int id);
        Task UpdateOwner(OwnerInformation ownerInformation);
        Task DeleteOwner(int id);
    }
}
