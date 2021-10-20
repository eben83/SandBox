namespace Integration.Strava.Dtos
{
    public class AuthenticationDetails
    {
        
        //properties
        public string TokenType { get; set; }
        public string RefreshToken { get; set; }
        public string AccessToken {get; set; }
        
        
        public void GetAuthenticationDetails()
        {
        }
    }
}