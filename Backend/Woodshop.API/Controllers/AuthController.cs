using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;
using RestSharp;

namespace Project.Controllers
{
    [ApiController]
    [Route("api")]
    public class AuthController : ControllerBase
    {
        private readonly string tokenUrl = "https://jonasdm.eu.auth0.com/oauth/token";
        [HttpGet]
        [Route("auth")]
        public async Task<ActionResult> GetToken()
        {
            try
            {
                var client = new RestClient(tokenUrl);
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");

                request.AddParameter("application/json", "{\"client_id\":\"wIOt3TK7hJNPuBrEMSzCOIbAFvFOznxY\",\"client_secret\":\"FgwvvclqYS3cn-lo_t8tziWoWDGIk45QYH9NfJ_WTyz8hGNbqOrRSoCNxOaWXWy_\",\"audience\":\"https://woodshopdocker\",\"grant_type\":\"client_credentials\"}", ParameterType.RequestBody);

                IRestResponse response = await client.ExecuteAsync(request);
                Auth auth = JsonConvert.DeserializeObject<Auth>(response.Content);
                var result = new
                {
                    access = auth.AccessToken,
                    type = auth.Type,
                };
                return Ok(result);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }


        }

    }
}
