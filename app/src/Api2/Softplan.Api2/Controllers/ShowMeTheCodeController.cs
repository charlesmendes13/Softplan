using Microsoft.AspNetCore.Mvc;
using Softplan.Api2.Application;

namespace Softplan.Api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly IShowMeTheCodeAppService _showMeTheCodeAppService;

        public ShowMeTheCodeController(IShowMeTheCodeAppService showMeTheCodeAppService)
        {
            _showMeTheCodeAppService = showMeTheCodeAppService;
        }

        [HttpGet]
        public ActionResult<string> ObterUrlGit()
        {
            return _showMeTheCodeAppService.Obter();
        }
    }
}
