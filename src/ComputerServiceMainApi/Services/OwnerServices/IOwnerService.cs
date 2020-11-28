using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerServiceModels.Models.Informations;

namespace ComputerServiceMainApi.Services.OwnerServices
{
    public interface IOwnerService
    {
        Task AddOwner(OwnerInformation ownerInformation);
        Task<IEnumerable<OwnerInformation>> GetOwners();
        Task<OwnerInformation> GetOwner(int id);
        Task UpdateOwner(OwnerInformation ownerInformation);
        Task DeleteOwner(int id);
    }
}
