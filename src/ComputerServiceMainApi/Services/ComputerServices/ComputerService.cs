using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerServiceMainApi.Reporitories.ComputerRepositories;
using ComputerServiceModels.Models.Configs;
using ComputerServiceModels.Models.EntitiesMongo;
using ComputerServiceModels.Models.Informations;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ComputerServiceMainApi.Services.ComputerServices
{
    public class ComputerService : IComputerService
    {
        private readonly IComputerRepository _repository;
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Log> _collection;
        private readonly MongoConfig _config;

        public ComputerService(IComputerRepository repository, IOptions<MongoConfig> config)
        {
            _repository = repository;
            _config = config.Value;
            _client = new MongoClient(_config.Client);
            _database = _client.GetDatabase(_config.Database);
            _collection = _database.GetCollection<Log>(_config.Collection);
        }

        public async Task AddComputer(ComputerInformation computerInformation)
        {
            var log = new Log() 
            {
                Name = "AddComputer",
                Time = DateTime.Now
            };

            await _collection.InsertOneAsync(log);
            await _repository.AddComputer(computerInformation);
        }
        
        public async Task<IEnumerable<ComputerInformation>> GetComputers()
        {
            var log = new Log()
            {
                Name = "GetComputers",
                Time = DateTime.Now
            };

            await _collection.InsertOneAsync(log);
            return await _repository.GetComputers();
        }

        public async Task<ComputerInformation> GetComputer(int id)
        {
            var log = new Log()
            {
                Name = "GetComputer",
                Time = DateTime.Now,
                Index = id
            };

            await _collection.InsertOneAsync(log);
            return await _repository.GetComputer(id);
        }

        public async Task UpdateComputer(ComputerInformation computerInformation)
        {
            var log = new Log()
            {
                Name = "UpdateComputer",
                Time = DateTime.Now,
                Index = computerInformation.ComputerId
            };

            await _collection.InsertOneAsync(log);
            await _repository.UpdateComputer(computerInformation);
        }

        public async Task DeleteComputer(int id)
        {
            var log = new Log()
            {
                Name = "DeleteComputer",
                Time = DateTime.Now,
                Index = id
            };

            await _collection.InsertOneAsync(log);
            await _repository.DeleteComputer(id);
        }
    }
}
