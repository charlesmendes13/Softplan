﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Softplan.Api2.Domain.Interfaces.Services;

namespace Softplan.Api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosService _calculaJurosService;

        public CalculaJurosController(ICalculaJurosService calculaJurosService)
        {
            _calculaJurosService = calculaJurosService;
        }

        [HttpGet]
        public decimal CalcularJuros([FromQuery] decimal valorInicial, [FromQuery] int meses)
        {
            return _calculaJurosService.Calcular(valorInicial, meses);
        }
    }
}
