using API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherNumberController : ControllerBase
    {
        private readonly IRepDevContext _IrepDevContext;

        public VoucherNumberController(IRepDevContext repDevContext)
        {
            _IrepDevContext = repDevContext;
        }

        [HttpGet("getData")]
        public async Task<IActionResult> GetData(string parameter = null, string ParameterPlus = null)
        {
            var param = new { parameter, ParameterPlus };
            var data = await _IrepDevContext.GetListObjectAsync<object>("GetDataInheritVoucherType", param);
            return Ok(data);
        }
    }
}
