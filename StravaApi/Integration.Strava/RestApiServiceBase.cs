using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Integration.Strava.Dtos;
using RestSharp;
using RestSharp.Authenticators;

namespace Integration.Strava
{
    public abstract class RestApiServiceBase
    {
        protected virtual async Task<HttpResponseMessage> GetApiResponse(string baseUrl, string token, string requestPath)
        {
            using (var client = new HttpClient())
            {
                //setup client
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3 | System.Net.SecurityProtocolType.Tls | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;

                //make request
                var response = await client.GetAsync(requestPath);
                return response;
            }
        }

        protected IRestResponse GetApiResponseWithRestSharp(string baseUrl, string requestPath)
        {
            var client = new RestClient(baseUrl);
            client.Authenticator = new HttpBasicAuthenticator("test", "test");
            
            var request = new RestRequest(requestPath);
            request.AddHeader("contentType", "application/json");

            var response = client.Get(request);

            return response;
        }
    }
}