using Softplan.Api2.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Api2.Application.Services
{
    public class ShowMeTheCodeService : IShowMeTheCodeService
    {
        public ShowMeTheCodeService()
        {

        }

        public string Obter()
        {
            const string GIT_URL = "https://github.com/charlesmendes13/softplan";

            return GIT_URL;
        }
    }
}
