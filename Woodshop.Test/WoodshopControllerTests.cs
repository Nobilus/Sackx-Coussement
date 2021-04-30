using System.Text;
using System.Net;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using FluentAssertions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.DTO;
using Project.Models;
using System.Net.Http.Headers;

namespace Woodshop.Test
{
    public class WoodshopControllerTestsUnauthorized : IClassFixture<WebApplicationFactory<Project.Startup>>
    {
        public HttpClient Client { get; }

        public WoodshopControllerTestsUnauthorized(WebApplicationFactory<Project.Startup> fixture)
        {
            Client = fixture.CreateClient();
        }

        [Fact]
        public async Task Get_Products()
        {
            var response = await Client.GetAsync("/api/products");
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var products = JsonConvert.DeserializeObject<List<ProductDTO>>(await response.Content.ReadAsStringAsync());
            Assert.True(products.Count > 0);
        }
        [Fact]
        public async Task Get_Product()
        {
            var productsResponse = await Client.GetAsync("/api/products");
            var products = JsonConvert.DeserializeObject<List<ProductDTO>>(await productsResponse.Content.ReadAsStringAsync());
            Guid productId = products[0].ProductId;

            var productResponse = await Client.GetAsync($"/api/products/{productId}");
            productResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            var product = JsonConvert.DeserializeObject<ProductDTO>(await productResponse.Content.ReadAsStringAsync());
            Assert.True(product.ProductId == productId);
        }
        [Fact]
        public async Task Get_Units()
        {
            var response = await Client.GetAsync("/api/units");
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var units = JsonConvert.DeserializeObject<List<Unit>>(await response.Content.ReadAsStringAsync());
            Assert.True(units.Count > 0);
        }

        [Fact]
        public async Task Add_Product()
        {
            var product = new ProductAddDTO()
            {
                Name = "test product",
                Thickness = 50,
                Width = 60,
                Price = 0.05,
                UnitId = 1,
            };
            string json = JsonConvert.SerializeObject(product);

            var response = await Client.PostAsync("/api/product", new StringContent(json, Encoding.UTF8, "application/json"));
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var createdProduct = JsonConvert.DeserializeObject<ProductDTO>(await response.Content.ReadAsStringAsync());
            Assert.NotNull(createdProduct);
        }

        [Fact]
        public async Task Get_Customers_Unauthorized()
        {
            var response = await Client.GetAsync("/api/customers");
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

    }

    public class WoodshopControllerTestsAuthorized : IClassFixture<WebApplicationFactory<Project.Startup>>
    {
        public HttpClient Client { get; }
        public WoodshopControllerTestsAuthorized(WebApplicationFactory<Project.Startup> fixture)
        {
            Client = fixture.CreateClient();
        }
    }
}
