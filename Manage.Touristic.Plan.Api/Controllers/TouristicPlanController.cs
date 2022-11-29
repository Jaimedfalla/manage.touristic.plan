using Manage.Touristic.Plan.Application.DTO;
using Manage.Touristic.Plan.Application.Interface;
using Manage.Touristic.Plan.Transversal.Common;
using Microsoft.AspNetCore.Mvc;

namespace Manage.Touristic.Plan.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class TouristicPlanController : ControllerBase
    {
        private readonly ITouristicPlanApplication _service;

        public TouristicPlanController(ITouristicPlanApplication service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] PlanDto Plan) {
            if (!ModelState.IsValid)
                return BadRequest();

            Response<bool> response = await _service.CreateAsync(Plan);

            return Ok(response);
        }
    }
}
