using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.DTO;
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
        [Route("products/{productId}")]
        public async Task<ActionResult<Product>> GetProduct(Guid productId)
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetProduct(productId));
            }
            catch (Exception ex)
            {
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
        [Route("customer/{customerId}")]
        public async Task<ActionResult<Customer>> GetCustomer(int customerId)
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetCustomer(customerId));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
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

        [HttpGet]
        [Route("staff/{staffId}")]
        public async Task<ActionResult<StaffDTO>> GetStaff(int staffId)
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetStaff(staffId));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        [Route("units")]
        public async Task<ActionResult<List<Unit>>> GetUnits()
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetUnits());
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        [Route("order")]
        public async Task<ActionResult<OrderDTO>> AddOrder(OrderDTO order)
        {
            try
            {
                return new OkObjectResult(await _woodshopService.AddOrder(order));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        [Route("customer")]
        public async Task<ActionResult<Customer>> AddCustomer(CustomerAddDTO customer)
        {
            try
            {
                return new OkObjectResult(await _woodshopService.AddCustomer(customer));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        [Route("product")]
        public async Task<ActionResult<ProductDTO>> AddProduct(ProductAddDTO product)
        {
            try
            {
                return new OkObjectResult(await _woodshopService.AddProduct(product));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
