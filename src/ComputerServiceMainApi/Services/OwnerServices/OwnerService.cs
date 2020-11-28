using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerServiceMainApi.Reporitories.OwnerRepositories;
using ComputerServiceModels.Models.EntitiesMongo;
using ComputerServiceModels.Models.Informations;
using MongoDB.Driver;

namespace ComputerServiceMainApi.Services.OwnerServices
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _repository;
        private MongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<Log> _collection;

        public OwnerService(IOwnerRepository repository)
        {
            _repository = repository;
            _client = new MongoClient("mongodb+srv://Igor:ComputerService@logs.hlrcj.mongodb.net/Logs?retryWrites=true&w=majority");
            _database = _client.GetDatabase("Los");
            _collection = _database.GetCollection<Log>("Logs");
        }

        public async Task AddOwner(OwnerInformation ownerInformation)
        {
            var log = new Log()
            {
                Name = "AddOwner",
                Time = DateTime.Now
            };

            await _collection.InsertOneAsync(log);
            await _repository.AddOwner(ownerInformation);
        }

        public async Task<IEnumerable<OwnerInformation>> GetOwners()
        {
            var log = new Log()
            {
                Name = "GetOwners",
                Time = DateTime.Now
            };

            await _collection.InsertOneAsync(log);
            return await _repository.GetOwners();
        }

        public async Task<OwnerInformation> GetOwner(int id)
        {
            var log = new Log()
            {
                Name = "GetOwner",
                Time = DateTime.Now,
                Index = id
            };

            await _collection.InsertOneAsync(log);
            return await _repository.GetOwner(id);
        }

        public async Task UpdateOwner(OwnerInformation ownerInformation)
        {
            var log = new Log()
            {
                Name = "UpdateOwner",
                Time = DateTime.Now,
                Index = ownerInformation.OwnerId
            };

            await _collection.InsertOneAsync(log);
            await _repository.UpdateOwner(ownerInformation);
        }

        public async Task DeleteOwner(int id)
        {
            var log = new Log()
            {
                Name = "DeleteOwner",
                Time = DateTime.Now,
                Index = id
            };

            await _collection.InsertOneAsync(log);
            await _repository.DeleteOwner(id);
        }
    }
}
