using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using IdentityModel;
using IdentityModel.Client;
using Newtonsoft.Json.Linq;

namespace TestZone
{
    public class ConsoleClient
    {
        private HttpClient client;
        private TokenResponse tokenResponse;
        //QUery an endpoint on a WEB api using ClientCredential
        public  async Task GetToken()
        {
            client = new HttpClient();
            var disco = await client.GetDiscoveryDocumentAsync("http://localhost:50414");
            if (disco.IsError)
            {
                Console.WriteLine(disco.Error);
                return;
            }
            tokenResponse = await client.RequestClientCredentialsTokenAsync(
                new ClientCredentialsTokenRequest
                {
                    Address = disco.TokenEndpoint,
                    ClientId = "client",
                    ClientSecret = "secret",
                    Scope = "api1"
                });
            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
                return;
            }
            Console.WriteLine(tokenResponse.Json);
            return;
        }
        public async Task QueryApi()
        {
            client.SetBearerToken(tokenResponse.AccessToken);            
            var response = await client.GetAsync("http://localhost:50414/api/values/1");
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(JArray.Parse(content));
            }
        }
    }
}
