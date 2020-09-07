using Softplan.Api2.Domain;

namespace Softplan.Api2.Application
{
    public class ShowMeTheCodeAppService : IShowMeTheCodeAppService
    {
        private readonly IShowMeTheCodeService _showMeTheCodeService;

        public ShowMeTheCodeAppService(IShowMeTheCodeService showMeTheCodeService)
        {
            _showMeTheCodeService = showMeTheCodeService;
        }

        public string Obter()
        {
            return _showMeTheCodeService.Obter();
        }
    }
}
