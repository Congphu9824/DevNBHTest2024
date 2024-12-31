using API.Repositories;
using Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartController : ControllerBase
    {
        private readonly IRepDevContext _IrepDevContext;

        public SmartController(IRepDevContext repDevContext)
        {
            _IrepDevContext = repDevContext;
        }

        [HttpGet]
        [Route("GetDataAlls")]
        public async Task<IActionResult> GetDataAll(DateTime? BeginDate = null, DateTime? EndDate = null)
        {
            int IdDonViOk = 100;
            string Paramater = "CollectVouchers";
            string Mid = "YesNo";
            string UserCode = "753f9da6-fa9f-4edf-a277-350813f45c54";
            var result = new { IdDonViOk, Paramater, Mid, UserCode, BeginDate, EndDate };
            var data = await _IrepDevContext.GetListObjectAsync<SmartData>("GetData", result);
            return Ok(data);
        }
    }
}
