using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [ApiController]
    [Route("api")]
    public class WoodshopController : ControllerBase
    {
        private readonly ILogger<WoodshopController> _logger;
        private readonly IWoodshopService _woodshopService;

        public WoodshopController(ILogger<WoodshopController> logger, IWoodshopService woodshopService)
        {
            _logger = logger;
            _woodshopService = woodshopService;

        }

        [HttpGet]
        [Route("products")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetProducts());
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return new StatusCodeResult(500);
            }
        }

    }
}
