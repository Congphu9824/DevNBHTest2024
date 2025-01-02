using System.Reflection;
using ApiDev.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace ApiDev.Services
{
    public interface IDataService
    {
        Task<bool> CreateDataAsync(string Entitytype, string JsonData);
        Task<bool> updateDataAsync(string Entitytype, string JsonData);

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
            await _db.AddAsync(entity);

                int count = await _db.SaveChangesAsync();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> updateDataAsync(string Entitytype, string JsonData)
        {
            var type = GetEntityType(Entitytype);
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
            var assembly = Assembly.GetAssembly(typeof(DevNbhtest2024Context));
            return assembly?.GetTypes().FirstOrDefault(t => t.Name == entityType);
        }


        //private Type GetEntityType(string entityType)
        //{
        //    Assembly assembly;
        //    assembly = Assembly.Load("Data"); // Tên assembly chứa các model

        //    var type = assembly.GetTypes().FirstOrDefault(t => t.Name == entityType);
        //    if (type == null)
        //    {
        //        return null;
        //    }
        //    return type;
        //}

        //public async Task<bool> CreateDataAsync(string entityType, string jsonData)
        //{
        //    var type = GetEntityType(entityType);
        //    if (type == null)
        //    {
        //        throw new ArgumentException("lỗi entityType");
        //    }

        //    var entity = JsonConvert.DeserializeObject(jsonData, type);
        //    if (entity == null)
        //    {
        //        throw new ArgumentException("lỗi jsonData");
        //    }

        //    var entry = _db.Entry(entity);
        //    if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)
        //    {
        //        _db.Add(entity);
        //    }

        //    await _db.SaveChangesAsync();
        //    return true;
        //}








    }
}
