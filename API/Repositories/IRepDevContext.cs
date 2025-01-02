using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace API.Repositories
{
    public interface IRepDevContext
    {
        Task<List<T>> GetListObjectAsync<T>(string storeName);
        Task<List<T>> GetListObjectAsync<T>(string storeName, object value);
    }

    public class RepDevContext(IConfiguration _Iconfiguration) : IRepDevContext
    {
        private readonly string connStr = _Iconfiguration.GetConnectionString("DefaultConnection");
        public async Task<List<T>> GetListObjectAsync<T>(string storeName)
        {
            IEnumerable<T> arr;
            using (var conn = new SqlConnection(connStr))
            {
                if(conn.State == ConnectionState.Closed)
                { conn.Open(); };
                try
                {
                    arr = await conn.QueryAsync<T>(storeName, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally { conn.Close(); conn.Dispose(); }
            }
            return arr.ToList();
        }

        public async Task<List<T>> GetListObjectAsync<T>(string storeName, object value)
        {
            IEnumerable<T> arr;
            using (var conn = new SqlConnection(connStr))
            {
                if (conn.State == ConnectionState.Closed)
                { conn.Open(); }
                try
                {
                    arr = await conn.QueryAsync<T>(storeName, value, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally { conn.Close(); conn.Dispose(); }
            }
            return arr.ToList();
        }
    }
}
