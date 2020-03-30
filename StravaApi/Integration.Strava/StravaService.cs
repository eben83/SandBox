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
            var client = new RestClient("www.strava.com");
            client.Authenticator = new SuperAuthenticator();
            
            var request = new RestRequest("/api/v3/athlete/activities?access_token=cacd7a0fcce8491472fa28da12ce6637604748ae");
            request.AddHeader("contentType", "application/json");

            var response = client.Get<List<ActivityDto>>(request);

            if (!response.IsSuccessful)
                throw new Exception(response.ErrorMessage);
            
            return response.Data;

        }
    }
}