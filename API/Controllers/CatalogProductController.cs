using API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogProductController : ControllerBase
    {
        private readonly IRepDevContext _IrepDevContext;

        public CatalogProductController(IRepDevContext repDevContext)
        {
            _IrepDevContext = repDevContext;
        }

        [HttpGet("getCatalogProduct")]
        public async Task<IActionResult> getCatalogProduct(string? Parameter, string? ProductCode)
        {
            var param = new { parameter = Parameter, productCode = ProductCode };
            var data = await _IrepDevContext.GetListObjectAsync<object>("GetCatalogProductDetails", param);
            return Ok(data);
        }
    }
}
