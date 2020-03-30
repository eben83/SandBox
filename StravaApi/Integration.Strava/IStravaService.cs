using System.Collections.Generic;
using Integration.Strava.Dtos;

namespace Integration.Strava
{
    public interface IStravaService
    {
        List<ActivityDto> GetActivities();
    }
}