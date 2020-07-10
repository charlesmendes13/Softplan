using Microsoft.AspNetCore.Mvc;
using Softplan.Api2.Domain.Interfaces.Services;

namespace Softplan.Api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly IShowMeTheCodeService _showMeTheCodeService;

        public ShowMeTheCodeController(IShowMeTheCodeService showMeTheCodeService)
        {
            _showMeTheCodeService = showMeTheCodeService;
        }

        [HttpGet]
        public ActionResult<string> ObterUrlGit()
        {
            return _showMeTheCodeService.Obter();
        }
    }
}
