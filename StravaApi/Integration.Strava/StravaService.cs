using System;
using System.Collections.Generic;
using Integration.Strava.Dtos;
using RestSharp;
using RestSharp.Authenticators;

namespace Integration.Strava
{
    

    public class StravaService : IStravaService
    {
        //fields
        private const string BASE_URL = "http://www.strava.com";
        private const string CLIENT_ID = "45021";
        private const string CLIENT_SECRET = "c258cacbe62c5e597322479531b3211e5cacc844";
        
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

        public void Authorize()
        {
            var client = new RestClient(BASE_URL);
            client.Authenticator = new HttpBasicAuthenticator(CLIENT_ID, CLIENT_SECRET);
            
            var request = new RestRequest("oauth/authorize");
        }

        public string GetToken()
        {
        } 
        
    }
}