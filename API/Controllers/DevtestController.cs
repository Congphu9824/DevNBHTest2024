using API.Entities;
using API.Repositories;
using API.Services;
using Data.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevtestController : ControllerBase
    {
        private readonly IRepDevContext _IrepDevContext;

        public DevtestController(IRepDevContext repDevContext)
        {
            _IrepDevContext = repDevContext;
        }

        [HttpGet("getData")]
        public async Task<IActionResult> GetData(string mid = null, string useCode = null, DateTime? beginDate = null, DateTime? endDate = null)
        {   
            int IdDonViOk = 100;
            string Paramater = "CollectVouchers";
            //string Mid = "YesNo"; 
            //string UserCode = "753f9da6-fa9f-4edf-a277-350813f45c54";
            //DateTime BeginDate = DateTime.Parse("2022-07-20 00:00:00");
            //DateTime EndDate = DateTime.Parse("2022-08-01 17:31:00");
            var result = new { IdDonViOk, Paramater, Mid = mid, UserCode = useCode, BeginDate = beginDate, EndDate = endDate };
            var data = await _IrepDevContext.GetListObjectAsync<object>("GetData", result);
            return Ok(data);
        }

    }
}
