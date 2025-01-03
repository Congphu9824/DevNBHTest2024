using ApiDev.Repositories;
using ApiDev.Services;
using Data.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiDevController : ControllerBase
    {
        private readonly IRepDevContext _IrepDevContext;
        private readonly IDataService _IdataService;

        public ApiDevController(IRepDevContext repDevContext, IDataService dataService)
        {
            _IrepDevContext = repDevContext;
            _IdataService = dataService;
        }

        [HttpGet]
        [Route("GetData")]
        public async Task<IActionResult> GetData(string? parameter, string? tablename, string? LoaiPhieu, string? maUser, string? codeUser, string? codeUnit, string? condition)
        {
            var param = new { parameter, tablename, LoaiPhieu, maUser, codeUser, codeUnit, condition };
            var Data = await _IrepDevContext.GetListObjectAsync<object>("SmartGetData", param);
            return Ok(Data);
        }

        [HttpDelete]
        [Route("DeleteData")]

        public async Task<IActionResult> DeleteData(string? parameter, string? tablename, string? keyData, string? dataPlus, string? maUser, string? codeUnit)
        {
            
            var param = new { parameter, tablename, keyData, dataPlus, maUser, codeUnit };
            var result = await _IrepDevContext.GetListObjectAsync<object>("DeleteData", param);
            return Ok(result);
        }

        [HttpPost]
        [Route("CreateData")]
        public async Task<ActionResult<object>> CreateData(ResponseContext dto)
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

        [HttpPut("UpdateData")]
        public async Task<IActionResult> UpdateData(ResponseContext dto)
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
    }
}
