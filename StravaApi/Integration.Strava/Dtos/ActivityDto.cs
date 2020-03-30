using System;

namespace Integration.Strava.Dtos
{
    public class ActivityDto : BaseDto
    {
        //fields
        public int Id { get; set; }
        public string Name { get; set; }
        public int Distance { get; set; }
        public int MovingTime { get; set; }
        public float AverageSpeed { get; set; }
    }
}