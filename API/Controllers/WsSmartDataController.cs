using API.Model;
using API.Repositories;
using API.Services;
using Azure;
using Data.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WsSmartDataController : ControllerBase
    {
        private readonly IRepDevContext _IrepDevContext;
        private readonly IDataService _IdataService;
        public WsSmartDataController(IRepDevContext repDevContext, IDataService dataService)
        {
            _IrepDevContext = repDevContext;
            _IdataService = dataService;
        }

        [HttpGet]
        [Route("GetDataWsSmarts")]
        public async Task<IEnumerable<WsmartMenu>> GetDataWsSmarts(DateTime? BeginDate = null, DateTime? EndDate = null)
        {
            int IdDonViOk = 100;
            string Paramater = "MENU";
            string Mid = "";
            string UserCode = "753f9da6-fa9f-4edf-a277-350813f45c54";
            var parameters = new
            {
                IdDonViOk,
                Paramater,
                Mid,
                UserCode,
                BeginDate,
                EndDate
            };
            var data = await _IrepDevContext.GetListObjectAsync<WsmartMenu>("WSmartGetData", parameters);

            return data;
        }

        [HttpPost("CreateData")]
        public async Task<IActionResult> CreateData(ResponseContext dto)
        {

            var result = await _IdataService.CreateDataAsync(dto.EntityType, dto.JsonData);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound(new { Message = "No data added" });
            }
        }

        [HttpPut("updateData")]
        public async Task<IActionResult> updateData(ResponseContext dto)
        {

            var result = await _IdataService.updateDataAsync(dto.EntityType, dto.JsonData);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound(new { Message = "No data added" });
            }
        }

        [HttpDelete("{tableName}/{id}")]
        public async Task<IActionResult> DeleteData(string tableName, Guid id)
        {
            string DataPlus = "";
            string MaUser = "";
            int CodeUnit = 0;
            var Parameter = "WSmartMenu";
            var param = new { parameter = Parameter, TableName = tableName, @KeyData = id, dataPlus = DataPlus, maUser = MaUser, codeUnit = CodeUnit };
            var result = await _IrepDevContext.GetListObjectAsync<object>("DeleteData", param);
            return Ok(result);
        }

    }
}
