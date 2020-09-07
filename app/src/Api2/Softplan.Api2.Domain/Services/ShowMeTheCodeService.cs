namespace Softplan.Api2.Domain
{
    public class ShowMeTheCodeService : IShowMeTheCodeService
    {
        public string Obter()
        {
            const string GIT_URL = "https://github.com/charlesmendes13/softplan";

            return GIT_URL;
        }
    }
}
