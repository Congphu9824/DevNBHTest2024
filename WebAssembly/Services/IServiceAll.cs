using System.Net.Http;
using System.Net.Http.Json;
using Data.DTO;
using Data.Model;

namespace WebAssembly.Services
{
    public interface IServiceAll
    {
        Task<List<SmartDatum>> GetSmartData();
        Task DeleteSmartData(Guid id);

        Task<bool> CreateData(ResponseContext request);
        Task<bool> updateWsSmartData(ResponseContext request);

    }
    public class ServiceAll(HttpClient _httpClient) : IServiceAll
    {
        public async Task<List<SmartDatum>> GetSmartData()
        {
            return await _httpClient.GetFromJsonAsync<List<SmartDatum>>("api/ApiDev/GetData?parameter=GetAll&tablename=SmartData&LoaiPhieu=InheritINV");
        }

        public async Task<bool> CreateData(ResponseContext request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ApiDev/CreateData", request);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> updateWsSmartData(ResponseContext request)
        {
            var response = await _httpClient.PutAsJsonAsync("api/ApiDev/UpdateData", request);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task DeleteSmartData(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/ApiDev/DeleteData?parameter=SmartData&tablename=SmartDatum&keyData={id}");
            if (response.IsSuccessStatusCode)
            {
                await _httpClient.GetFromJsonAsync<List<SmartDatum>>("api/ApiDev/GetData?parameter=GetAll&tablename=SmartData&LoaiPhieu=InheritUNC");
            }
        }
    }

}
