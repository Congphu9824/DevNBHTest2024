using System.Net.Http;
using System.Net.Http.Json;
using Data.DTO;
using Data.Model;

namespace WebAssembly.Services
{
    public interface IServiceWarehose
    {
        Task<List<CategoryWarehose>> GetWarehose();
        Task DeleteWarehose(Guid id);
        Task<bool> CreateWarehose(ResponseContext response);
        Task<bool> updateWarehose(ResponseContext response);
    }
    public class ServiceWarehose(HttpClient _httpClient) : IServiceWarehose
    {
        public async Task<bool> CreateWarehose(ResponseContext response)
        {
            var result = await _httpClient.PostAsJsonAsync("api/ApiDev/CreateData", response);
            if (result.IsSuccessStatusCode) 
            {
                return true;
            }
            return false;
        }
        public async Task<bool> updateWarehose(ResponseContext response)
        {
            var result = await _httpClient.PutAsJsonAsync("api/ApiDev/UpdateData", response);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task DeleteWarehose(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/ApiDev/DeleteData?parameter=CategoryWarehose&tablename=CategoryWarehose/{id}");
            if (response.IsSuccessStatusCode)
            {
                await _httpClient.GetFromJsonAsync<List<CategoryWarehose>>("api/ApiDev/GetData?parameter=GetAll&tablename=CategoryWarehose&LoaiPhieu=ListWarehose");
            }
    
        }

        public async Task<List<CategoryWarehose>> GetWarehose()
        {
            return await _httpClient.GetFromJsonAsync<List<CategoryWarehose>>("api/ApiDev/GetData?parameter=GetAll&tablename=CategoryWarehose&LoaiPhieu=ListWarehose");
        }

     
    }
}
