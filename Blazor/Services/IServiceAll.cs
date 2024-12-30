using System.Net.Http.Json;
using Data.Model;

namespace Blazor.Services
{
    public interface IServiceAll
    {
        Task<List<SmartData>> Getall();
    }
    public class ServiceAll(HttpClient _httpClient) : IServiceAll
    {

        public async Task<List<SmartData>> Getall()
        {
            var result = await _httpClient.GetFromJsonAsync<List<SmartData>>("api/Devtest/getData?mid=yesNo&useCode=753f9da6-fa9f-4edf-a277-350813f45c54");
            return result;
        }
    }
}
