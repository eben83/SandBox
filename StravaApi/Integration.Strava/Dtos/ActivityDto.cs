using System;

namespace Integration.Strava.Dtos
{
    public class ActivityDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDt { get; set; }
    }
}