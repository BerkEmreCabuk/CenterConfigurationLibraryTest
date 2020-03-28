using ConfLib.Extensions;
using ConfLib.Models;
using ConfLib.Models.Enums;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConfLib.Lib.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly string _applicationName;
        private readonly string _connectionString;
        private readonly IMongoCollection<ConfigurationModel> mongoCollection;

        public ConfigurationService(string applicationName,string connectionString)
        {
            _applicationName = applicationName;
            _connectionString = connectionString;
            var client = new MongoClient(_connectionString);
            var database = client.GetDatabase("ConfDB");
            mongoCollection = database.GetCollection<ConfigurationModel>("ConfCollection");
        }

        public async Task<T> GetValue<T>(string key)
        {
            Type type=typeof(T);
            
            var resultList =await mongoCollection.Find(m => m.Status == Status.Active && m.ApplicationName.Equals(_applicationName) && m.Name.Equals(key)).ToListAsync();
            foreach (var item in resultList)
            {
                if((item.Type).GetDescription().ToLower().Equals(type.Name.ToLower()))
                     return (T)Convert.ChangeType(item.Value, typeof(T));
            }
            return (T)Convert.ChangeType(null, typeof(T));
        }
    }
}
