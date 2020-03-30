using System;
using System.Collections.Generic;
using Integration.Strava.Dtos;
using RestSharp;
using RestSharp.Authenticators;

namespace Integration.Strava
{
    public class StravaService : IStravaService
    {
        public List<ActivityDto> GetActivities()
        {
            var client = new RestClient("");
            client.Authenticator = new HttpBasicAuthenticator("test", "test");
            
            var request = new RestRequest("");
            request.AddHeader("contentType", "application/json");

            var response = client.Get<List<ActivityDto>>(request);

            if (!response.IsSuccessful)
                throw new Exception(response.ErrorMessage);
            
            return response.Data;

        }

        public Method Authentication(AuthenticationDetails)
        {
           
        }
        
    }
}