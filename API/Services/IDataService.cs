using System.Reflection;
using API.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace API.Services
{
    public interface IDataService
    {
        Task<bool> CreateDataAsync(string Entitytype, string JsonData);
    }

    public class DataService(DevNbhtest2024Context _db) : IDataService
    {
        public async Task<bool> CreateDataAsync(string EntityType, string JsonData)
        {
            var type = GetEntityType(EntityType);
            var entity = JsonConvert.DeserializeObject(JsonData, type);
            if (entity == null)
            {
                throw new ArgumentException("lỗi sai data");
            }
            _db.Update(entity);

            int count = await _db.SaveChangesAsync();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        private Type GetEntityType(string entityType)
        {
            Assembly assembly;
            assembly = Assembly.Load("Data"); // Tên assembly chứa các model

            var type = assembly.GetTypes().FirstOrDefault(t => t.Name == entityType);
            if (type == null)
            {
                return null;
            }
            return type;
        }
    }
}
