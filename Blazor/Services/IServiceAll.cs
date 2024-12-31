using System.Net.Http.Json;
using Data.Model;
using static System.Net.WebRequestMethods;
using Syncfusion.Blazor.Diagram;
using Data.DTO;
namespace Blazor.Services
{
    public interface IServiceAll
    {
        Task<List<SmartData>> GetSmartData();
        Task<List<WsmartMenu>> GetSmartMenus();

        Task DeleteSmartMenu(Guid id);

        Task<bool> CreateWsSmartData(ResponseContext request);
        Task<bool> updateWsSmartData(ResponseContext request);
        
    }
    public class ServiceAll(HttpClient _httpClient) : IServiceAll
    {
        public async Task<bool> CreateWsSmartData(ResponseContext request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/WsSmartData/CreateData", request);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> updateWsSmartData(ResponseContext request)
        {
            var response = await _httpClient.PutAsJsonAsync("api/WsSmartData/updateData", request);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task DeleteSmartMenu(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/WsSmartData/WsmartMenu/{id}");
            if (response.IsSuccessStatusCode)
            {
                await _httpClient.GetFromJsonAsync<List<WsmartMenu>>("api/WsSmartData/GetDataWsSmart");
            }
        }

        public async Task<List<SmartData>> GetSmartData()
        {
            return await _httpClient.GetFromJsonAsync<List<SmartData>>("api/Smart/GetDataAlls");
        }

        public async Task<List<WsmartMenu>> GetSmartMenus()
        {
            var result = await _httpClient.GetFromJsonAsync<List<WsmartMenu>>("api/WsSmartData/GetDataWsSmarts");
            return result;
        }

     
    }
}
