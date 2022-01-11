using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.DTO;
using Project.Models;
using Project.Services;
using Woodshop.API.Models;

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
        // [ResponseCache(Duration = 86400, Location = ResponseCacheLocation.Any)]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            string orderby = HttpContext.Request.Query["orderby"].ToString();
            string query = HttpContext.Request.Query["q"].ToString();
            try
            {
                return new OkObjectResult(await _woodshopService.GetProducts(orderby, query));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.InnerException);
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
        [Route("products/withgroups")]
        public async Task<ActionResult<List<ProductGroup>>> GetProductsWithGroups()
        {
            try
            {
                string query = HttpContext.Request.Query["q"].ToString();
                return new OkObjectResult(await _woodshopService.ListProductgroupsWithProducts(query));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }
        [HttpGet]
        [Route("products/groups")]
        public async Task<ActionResult<List<ProductGroup>>> GetProductgroups()
        {
            try
            {
                return new OkObjectResult(await _woodshopService.ListProductgroups());
            }
            catch (Exception ex)
            {
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

        // [Authorize]
        [HttpGet]
        [Route("customers")]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            string query = HttpContext.Request.Query["q"].ToString();
            try
            {
                return new OkObjectResult(await _woodshopService.GetCustomers(query));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        // [Authorize]
        [HttpGet]
        [Route("customer/{customerId}")]
        public async Task<ActionResult<Customer>> GetCustomer(Guid customerId)
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetCustomer(customerId));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        // [Authorize]
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
                return new StatusCodeResult(500);
            }
        }

        // [Authorize]
        [HttpGet]
        [Route("customer/validate/{vatNumber}")]
        public async Task<ActionResult<Customer>> CheckVATNumber(string vatNumber)
        {
            try
            {
                return new OkObjectResult(await _woodshopService.ValidateVatnumber(vatNumber));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        // [Authorize]
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

        // [Authorize]
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

        // [Authorize]
        [HttpPost]
        [Route("staff")]
        public async Task<ActionResult<Staff>> AddStaff(StaffAddDTO staff)
        {
            try
            {
                return new OkObjectResult(await _woodshopService.AddStaff(staff));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        [Route("units")]
        [ResponseCache(Duration = 86400, Location = ResponseCacheLocation.Any)]
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

        // [Authorize]
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

        // [Authorize]
        [HttpPatch]
        [Route("order/switch/{orderId}")]
        public async Task<ActionResult<OrdersDTO>> SwitchOrderType(Guid id)
        {
            try
            {
                return new OkObjectResult(await _woodshopService.SwitchOrderType(id));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        // [Authorize]
        [HttpGet]
        [Route("orders")]
        public async Task<ActionResult<List<OrdersDTO>>> GetOrders()
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetOrders());
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }
        [HttpGet]
        [Route("bestelbons")]
        public async Task<ActionResult<List<List<OrdersDTO>>>> GetbestelBons()
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetBestelbons());
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }
        [HttpGet]
        [Route("offertes")]
        public async Task<ActionResult<List<List<OrdersDTO>>>> GetOffertes()
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetOffertes());
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        // [Authorize]
        [HttpGet]
        [Route("order/{orderId}")]
        public async Task<ActionResult<OrdersDTO>> GetOrder(Guid orderId)
        {
            try
            {
                return new OkObjectResult(await _woodshopService.GetOrder(orderId));
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
