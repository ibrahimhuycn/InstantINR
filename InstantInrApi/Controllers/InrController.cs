using Microsoft.AspNetCore.Mvc;

namespace InstantInrApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InrDataController : ControllerBase
    {

        private readonly ILogger<InrDataController> _logger;
        private readonly IInrData _inrData;

        public InrDataController(ILogger<InrDataController> logger, IInrData inrData)
        {
            _logger = logger;
            _inrData = inrData;
        }

        [HttpGet(Name = "GetInrData")]
        public ActionResult<InrDataModel> Get()
        {
            var data = _inrData.ReadInrData();
            if (data is not null)
            {
                return Ok(data);
            }
            return NotFound();
        }

        [HttpPost(Name = "PostInrData")]
        public ActionResult SaveInr(InrDataModel inrDataModel)
        {
            if (_inrData.WriteInrData(inrDataModel))
            {
                return Ok();
            }

            return NotFound();
        }

    }
}