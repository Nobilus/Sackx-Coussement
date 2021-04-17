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

        [HttpGet]
        [Route("customers")]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetCustomers());
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        [Route("staff")]
        public async Task<ActionResult<List<Staff>>> GetStaff()
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetStaffs());
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

    }
}
